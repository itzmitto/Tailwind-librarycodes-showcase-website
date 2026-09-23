const recipeSections = document.getElementById("recipe-sections");
const recipeCount = document.getElementById("recipe-count");
const recipeSearch = document.getElementById("recipe-search");
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

let recipes = [];
let activeRecipe = null;
let activeCategory = "All";
let searchQuery = "";

const categoryAccents = {
  Buttons: "text-cyan-500",
  Cards: "text-emerald-500",
  Inputs: "text-cyan-500",
  Badges: "text-emerald-500",
  Glass: "text-cyan-500",
  Gradients: "text-emerald-500",
  Shadows: "text-cyan-500",
  Grids: "text-emerald-500",
  Typography: "text-cyan-500",
  Loading: "text-emerald-500",
  Alerts: "text-cyan-500",
  Progress: "text-emerald-500",
  Utilities: "text-cyan-500",
};

function groupRecipesByCategory(items) {
  return items.reduce((groups, recipe) => {
    if (!groups[recipe.category]) {
      groups[recipe.category] = [];
    }

    groups[recipe.category].push(recipe);

    return groups;
  }, {});
}

function getFilteredRecipes() {
  return recipes.filter((recipe) => {
    const matchesCategory =
      activeCategory === "All" || recipe.category === activeCategory;

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
}

function createRecipeCard(recipe) {
  const article = document.createElement("article");

  article.className =
    "group cursor-pointer overflow-hidden rounded-2xl border border-slate-200 bg-white transition duration-200 hover:-translate-y-1 hover:border-cyan-300 hover:shadow-xl hover:shadow-slate-200/60";

  article.tabIndex = 0;
  article.dataset.recipeId = recipe.id;

  article.innerHTML = `
        <div class="flex min-h-56 items-center justify-center bg-slate-50 p-8">
            <div class="w-full">
                ${recipe.preview}
            </div>
        </div>

        <div class="border-t border-slate-200 p-5">
            <div class="flex items-start justify-between gap-4">
                <div>
                    <h3 class="font-bold text-slate-950">
                        ${recipe.name}
                    </h3>

                    <p class="mt-2 text-sm leading-6 text-slate-500">
                        ${recipe.description}
                    </p>
                </div>

                <span class="shrink-0 font-['DM_Mono'] text-[9px] uppercase tracking-[0.1em] text-slate-400">
                    ${recipe.category}
                </span>
            </div>

            <div class="mt-5 flex items-center justify-between border-t border-slate-100 pt-4">
                <span class="font-['DM_Mono'] text-[9px] uppercase tracking-[0.1em] text-slate-400">
                    Recipe ${String(recipe.id).padStart(2, "0")}
                </span>

                <span class="text-xs font-bold text-cyan-600 transition group-hover:translate-x-1">
                    View code →
                </span>
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
                    ${items.length} ${items.length === 1 ? "recipe" : "recipes"}
                </div>
            </div>

            <div class="grid grid-cols-1 gap-5 md:grid-cols-2 xl:grid-cols-4" data-recipe-grid></div>
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

  button.type = "button";
  button.textContent = category;

  button.className = isActive
    ? "rounded-xl bg-slate-950 px-4 py-2.5 font-['DM_Mono'] text-[10px] font-medium uppercase tracking-[0.08em] text-white transition"
    : "rounded-xl border border-slate-200 bg-white px-4 py-2.5 font-['DM_Mono'] text-[10px] font-medium uppercase tracking-[0.08em] text-slate-500 transition hover:border-cyan-300 hover:text-cyan-600";

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
    ...new Set(recipes.map((recipe) => recipe.category)),
  ];

  categoryFilters.innerHTML = "";

  categories.forEach((category) => {
    categoryFilters.appendChild(createFilterButton(category));
  });
}

function openRecipe(recipe) {
  activeRecipe = recipe;

  modalCategory.textContent = recipe.category;
  modalTitle.textContent = recipe.name;
  modalDescription.textContent = recipe.description;

  modalPreview.innerHTML = recipe.preview;
  modalCode.textContent = recipe.code.trim();

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
}

async function copyRecipeCode() {
  if (!activeRecipe) {
    return;
  }

  const value = activeRecipe.code.trim();

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

  copyCode.textContent = "Copied";

  setTimeout(() => {
    copyCode.textContent = "Copy code";
  }, 1200);
}

async function loadRecipes() {
  try {
    const response = await fetch("/api/recipes");

    if (!response.ok) {
      throw new Error("Could not load recipes.");
    }

    recipes = await response.json();

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

recipeSearch.addEventListener("input", (event) => {
  searchQuery = event.target.value.trim();
  renderRecipes();
});

modalClose.addEventListener("click", closeRecipe);
modalBackdrop.addEventListener("click", closeRecipe);
copyCode.addEventListener("click", copyRecipeCode);

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

loadRecipes();
