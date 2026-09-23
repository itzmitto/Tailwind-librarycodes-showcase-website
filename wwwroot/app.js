const recipeSections = document.getElementById("recipe-sections");
const recipeCount = document.getElementById("recipe-count");
const favoriteCount = document.getElementById("favorite-count");
const recipeSearch = document.getElementById("recipe-search");
const recipeSort = document.getElementById("recipe-sort");
const categoryFilters = document.getElementById("category-filters");
const emptyState = document.getElementById("empty-state");

const modal = document.getElementById("recipe-modal");
const modalBackdrop = document.getElementById("recipe-modal-backdrop");
const modalClose = document.getElementById("modal-close");
const modalCategory = document.getElementById("modal-category");
const modalTitle = document.getElementById("modal-title");
const modalDescription = document.getElementById("modal-description");
const modalPreview = document.getElementById("modal-preview");
const modalCode = document.getElementById("modal-code");
const copyCode = document.getElementById("copy-code");
const codeTabs = document.querySelectorAll("[data-code-tab]");

let recipes = [];
let activeRecipe = null;
let activeCategory = "All";
let activeCodeTab = "html";
let searchQuery = "";
let sortMode = "default";

let favorites = new Set(
  JSON.parse(localStorage.getItem("tailwind-recipe-favorites") || "[]"),
);

const categoryAccents = {
  Buttons: "text-cyan-500",
  Cards: "text-emerald-500",
  Inputs: "text-cyan-500",
  Badges: "text-emerald-500",
  Glass: "text-cyan-500",
  Glassmorphism: "text-cyan-500",
  Gradients: "text-emerald-500",
  Shadows: "text-cyan-500",
  Grids: "text-emerald-500",
  Typography: "text-cyan-500",
  Loading: "text-emerald-500",
  Alerts: "text-cyan-500",
  Progress: "text-emerald-500",
  Utilities: "text-cyan-500",
  Checkboxes: "text-emerald-500",
  Radio: "text-cyan-500",
  Selects: "text-emerald-500",
  Controls: "text-cyan-500",
  Tooltips: "text-emerald-500",
  Dropdowns: "text-cyan-500",
  Tabs: "text-emerald-500",
  Accordions: "text-cyan-500",
  Modals: "text-emerald-500",
  Toasts: "text-cyan-500",
  Pagination: "text-emerald-500",
  Layouts: "text-cyan-500",
  Stats: "text-emerald-500",
  Avatars: "text-cyan-500",
  "Empty States": "text-emerald-500",
  Forms: "text-cyan-500",
  "JavaScript UI": "text-emerald-500",
  "JavaScript Utilities": "text-cyan-500",
  Tables: "text-emerald-500",
  Breadcrumbs: "text-cyan-500",
  "Command Palette": "text-emerald-500",
  Pricing: "text-cyan-500",
  Timeline: "text-emerald-500",
  Steppers: "text-cyan-500",
  "Code Blocks": "text-emerald-500",
  Notifications: "text-cyan-500",
  Menus: "text-emerald-500",
  Data: "text-cyan-500",
  Neon: "text-cyan-500",
  Effects: "text-emerald-500",
};

function saveFavorites() {
  localStorage.setItem(
    "tailwind-recipe-favorites",
    JSON.stringify([...favorites]),
  );

  updateFavoriteCount();
}

function updateFavoriteCount() {
  favoriteCount.textContent = favorites.size;
}

function toggleFavorite(id) {
  if (favorites.has(id)) {
    favorites.delete(id);
  } else {
    favorites.add(id);
  }

  saveFavorites();
  renderCategoryFilters();
  renderRecipes();
}

function groupRecipesByCategory(items) {
  return items.reduce((groups, recipe) => {
    if (!groups[recipe.category]) {
      groups[recipe.category] = [];
    }

    groups[recipe.category].push(recipe);

    return groups;
  }, {});
}

function sortRecipes(items) {
  const sorted = [...items];

  if (sortMode === "newest") {
    return sorted.sort((a, b) => b.id - a.id);
  }

  if (sortMode === "name") {
    return sorted.sort((a, b) => a.name.localeCompare(b.name));
  }

  if (sortMode === "category") {
    return sorted.sort(
      (a, b) =>
        a.category.localeCompare(b.category) || a.name.localeCompare(b.name),
    );
  }

  return sorted.sort((a, b) => a.id - b.id);
}

function getFilteredRecipes() {
  const filtered = recipes.filter((recipe) => {
    let matchesCategory = false;

    if (activeCategory === "All") {
      matchesCategory = true;
    } else if (activeCategory === "Favorites") {
      matchesCategory = favorites.has(recipe.id);
    } else {
      matchesCategory = recipe.category === activeCategory;
    }

    const searchableText = [
      recipe.name,
      recipe.category,
      recipe.description,
      recipe.accent,
    ]
      .join(" ")
      .toLowerCase();

    const matchesSearch = searchableText.includes(searchQuery.toLowerCase());

    return matchesCategory && matchesSearch;
  });

  return sortRecipes(filtered);
}

function getCategoryCount(category) {
  if (category === "All") {
    return recipes.length;
  }

  if (category === "Favorites") {
    return recipes.filter((recipe) => favorites.has(recipe.id)).length;
  }

  return recipes.filter((recipe) => recipe.category === category).length;
}

async function copyText(value, button) {
  try {
    await navigator.clipboard.writeText(value);
  } catch {
    const textarea = document.createElement("textarea");

    textarea.value = value;
    textarea.style.position = "fixed";
    textarea.style.opacity = "0";

    document.body.appendChild(textarea);

    textarea.select();

    document.execCommand("copy");

    textarea.remove();
  }

  const originalText = button.textContent.trim();

  button.textContent = "Copied";

  setTimeout(() => {
    button.textContent = originalText;
  }, 1200);
}

function createRecipeCard(recipe) {
  const article = document.createElement("article");

  const isFavorite = favorites.has(recipe.id);

  article.className =
    "group cursor-pointer overflow-hidden rounded-2xl border border-slate-200 bg-white transition duration-200 hover:-translate-y-1 hover:border-cyan-300 hover:shadow-xl hover:shadow-slate-200/60";

  article.tabIndex = 0;

  article.innerHTML = `
        <div class="flex min-h-56 items-center justify-center bg-slate-50 p-8">
            <div class="w-full">
                ${recipe.preview}
            </div>
        </div>

        <div class="border-t border-slate-200 p-5">
            <div class="flex min-h-[92px] items-start justify-between gap-4">
                <div class="min-w-0">
                    <h3 class="font-bold text-slate-950">
                        ${recipe.name}
                    </h3>

                    <p class="mt-2 text-sm leading-6 text-slate-500">
                        ${recipe.description}
                    </p>
                </div>

                <span class="shrink-0 font-['DM_Mono'] text-[9px] uppercase tracking-[0.12em] text-slate-400">
                    ${recipe.category}
                </span>
            </div>

            <div class="mt-5 flex items-center justify-between gap-4 border-t border-slate-100 pt-4">
                <span class="shrink-0 font-['DM_Mono'] text-[9px] uppercase tracking-[0.12em] text-slate-400">
                    Recipe ${String(recipe.id).padStart(2, "0")}
                </span>

                <div class="flex items-center gap-2">
                    <button
                        type="button"
                        data-favorite
                        aria-label="${
                          isFavorite
                            ? "Remove from favorites"
                            : "Add to favorites"
                        }"
                        class="${
                          isFavorite
                            ? "flex size-9 items-center justify-center rounded-lg border border-emerald-300 bg-emerald-50 text-base text-emerald-600 transition hover:bg-emerald-100"
                            : "flex size-9 items-center justify-center rounded-lg border border-slate-200 bg-white text-base text-slate-400 transition hover:border-emerald-300 hover:bg-emerald-50 hover:text-emerald-600"
                        }"
                    >
                        ${isFavorite ? "★" : "☆"}
                    </button>

                    <button
                        type="button"
                        data-copy-card
                        class="rounded-lg border border-slate-200 bg-white px-3.5 py-2.5 font-['DM_Mono'] text-[9px] font-medium uppercase tracking-[0.08em] text-slate-500 transition hover:border-cyan-300 hover:bg-cyan-50 hover:text-cyan-600"
                    >
                        Copy
                    </button>

                    <button
                        type="button"
                        data-view-card
                        class="rounded-lg bg-cyan-400 px-3.5 py-2.5 text-xs font-bold text-slate-950 transition hover:bg-cyan-300 active:scale-95"
                    >
                        View code
                    </button>
                </div>
            </div>
        </div>
    `;

  article.addEventListener("click", () => {
    openRecipe(recipe);
  });

  article.addEventListener("keydown", (event) => {
    if (event.key === "Enter" || event.key === " ") {
      event.preventDefault();
      openRecipe(recipe);
    }
  });

  const copyButton = article.querySelector("[data-copy-card]");

  const favoriteButton = article.querySelector("[data-favorite]");

  const viewButton = article.querySelector("[data-view-card]");

  copyButton.addEventListener("click", (event) => {
    event.stopPropagation();

    copyText(recipe.code.trim(), copyButton);
  });

  favoriteButton.addEventListener("click", (event) => {
    event.stopPropagation();

    toggleFavorite(recipe.id);
  });

  viewButton.addEventListener("click", (event) => {
    event.stopPropagation();

    openRecipe(recipe);
  });

  return article;
}

function renderRecipes() {
  const filteredRecipes = getFilteredRecipes();

  const groupedRecipes = groupRecipesByCategory(filteredRecipes);

  recipeSections.innerHTML = "";

  recipeCount.textContent = filteredRecipes.length;

  if (filteredRecipes.length === 0) {
    emptyState.classList.remove("hidden");

    return;
  }

  emptyState.classList.add("hidden");

  Object.entries(groupedRecipes).forEach(([category, items], index) => {
    const section = document.createElement("section");

    section.className =
      index === 0 ? "py-14" : "border-t border-slate-200 py-14";

    const accentClass = categoryAccents[category] || "text-cyan-500";

    section.innerHTML = `
                <div class="mb-8 flex items-end justify-between gap-10">
                    <div>
                        <div class="font-['DM_Mono'] text-[10px] uppercase tracking-[0.15em] ${accentClass}">
                            ${String(index + 1).padStart(2, "0")} / ${category}
                        </div>

                        <h2 class="mt-2 text-3xl font-extrabold tracking-[-0.04em] text-slate-950">
                            ${category}
                        </h2>
                    </div>

                    <div class="font-['DM_Mono'] text-[10px] uppercase tracking-[0.12em] text-slate-400">
                        ${items.length} ${
                          items.length === 1 ? "recipe" : "recipes"
                        }
                    </div>
                </div>

                <div
                    class="grid grid-cols-1 gap-5 md:grid-cols-2 xl:grid-cols-4"
                    data-recipe-grid
                ></div>
            `;

    const grid = section.querySelector("[data-recipe-grid]");

    items.forEach((recipe) => {
      grid.appendChild(createRecipeCard(recipe));
    });

    recipeSections.appendChild(section);
  });
}

function createFilterButton(category) {
  const button = document.createElement("button");

  const isActive = activeCategory === category;

  const count = getCategoryCount(category);

  button.type = "button";

  button.className = isActive
    ? "flex items-center gap-2 rounded-xl bg-slate-950 px-4 py-2.5 font-['DM_Mono'] text-[9px] font-medium uppercase tracking-[0.08em] text-white"
    : "flex items-center gap-2 rounded-xl border border-slate-200 bg-white px-4 py-2.5 font-['DM_Mono'] text-[9px] font-medium uppercase tracking-[0.08em] text-slate-500 transition hover:border-cyan-300 hover:text-cyan-600";

  button.innerHTML = `
        <span>${category}</span>

        <span class="${isActive ? "text-slate-400" : "text-slate-300"}">
            ${count}
        </span>
    `;

  button.addEventListener("click", () => {
    activeCategory = category;

    renderCategoryFilters();
    renderRecipes();
  });

  return button;
}

function renderCategoryFilters() {
  const categories = [
    "All",
    "Favorites",
    ...new Set(recipes.map((recipe) => recipe.category)),
  ];

  categoryFilters.innerHTML = "";

  categories.forEach((category) => {
    categoryFilters.appendChild(createFilterButton(category));
  });
}

function getActiveCode() {
  if (!activeRecipe) {
    return "";
  }

  if (activeCodeTab === "css") {
    return activeRecipe.css || "";
  }

  if (activeCodeTab === "javascript") {
    return activeRecipe.javaScript || "";
  }

  return activeRecipe.code || "";
}

function renderCodeTabs() {
  codeTabs.forEach((button) => {
    const tab = button.dataset.codeTab;

    let available = true;

    if (tab === "css") {
      available = Boolean(activeRecipe?.css);
    }

    if (tab === "javascript") {
      available = Boolean(activeRecipe?.javaScript);
    }

    button.classList.toggle("hidden", !available);

    const isActive = tab === activeCodeTab;

    button.classList.toggle("bg-white/10", isActive);

    button.classList.toggle("text-white", isActive);

    button.classList.toggle("text-slate-400", !isActive);
  });

  modalCode.textContent = getActiveCode().trim();
}

function openRecipe(recipe) {
  activeRecipe = recipe;
  activeCodeTab = "html";

  modalCategory.textContent = recipe.category;

  modalTitle.textContent = recipe.name;

  modalDescription.textContent = recipe.description;

  modalPreview.innerHTML = recipe.preview;

  renderCodeTabs();

  modal.classList.remove("hidden");

  modal.classList.add("flex");

  document.body.classList.add("overflow-hidden");

  copyCode.textContent = "Copy code";
}

function closeRecipe() {
  modal.classList.add("hidden");

  modal.classList.remove("flex");

  document.body.classList.remove("overflow-hidden");

  activeRecipe = null;
  activeCodeTab = "html";
}

codeTabs.forEach((button) => {
  button.addEventListener("click", () => {
    activeCodeTab = button.dataset.codeTab;

    renderCodeTabs();
  });
});

copyCode.addEventListener("click", () => {
  const value = getActiveCode().trim();

  if (!value) {
    return;
  }

  copyText(value, copyCode);
});

recipeSearch.addEventListener("input", (event) => {
  searchQuery = event.target.value.trim();

  renderRecipes();
});

recipeSort.addEventListener("change", (event) => {
  sortMode = event.target.value;

  renderRecipes();
});

modalClose.addEventListener("click", closeRecipe);

modalBackdrop.addEventListener("click", closeRecipe);

window.addEventListener("keydown", (event) => {
  if (event.key === "Escape" && !modal.classList.contains("hidden")) {
    closeRecipe();
  }

  if (
    event.key === "/" &&
    document.activeElement !== recipeSearch &&
    modal.classList.contains("hidden")
  ) {
    event.preventDefault();

    recipeSearch.focus();
  }
});

async function loadRecipes() {
  try {
    const response = await fetch("/api/recipes");

    if (!response.ok) {
      throw new Error();
    }

    recipes = await response.json();

    updateFavoriteCount();
    renderCategoryFilters();
    renderRecipes();
  } catch {
    recipeSections.innerHTML = `
            <div class="py-24 text-center">
                <div class="text-xl font-bold text-slate-950">
                    Recipes could not be loaded
                </div>

                <p class="mt-2 text-sm text-slate-500">
                    Check whether the C# server is running.
                </p>
            </div>
        `;
  }
}

loadRecipes();
