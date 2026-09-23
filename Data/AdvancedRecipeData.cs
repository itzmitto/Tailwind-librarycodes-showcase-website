public static class AdvancedRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 68,
            Name = "Interactive Modal",
            Category = "JavaScript UI",
            Description = "Reusable modal with open, close, backdrop and Escape handling.",
            Accent = "cyan",
            Preview = """
            <div class="w-full max-w-sm rounded-3xl border border-slate-200 bg-white p-6 shadow-xl shadow-slate-200/70">
                <div class="flex size-11 items-center justify-center rounded-xl bg-cyan-100 font-bold text-cyan-700">
                    M
                </div>
                <h3 class="mt-5 text-xl font-extrabold text-slate-950">
                    Interactive Modal
                </h3>
                <p class="mt-2 text-sm leading-6 text-slate-500">
                    Open and close a dialog with JavaScript.
                </p>
                <button class="mt-5 rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Open modal
                </button>
            </div>
            """,
            Code = """
            <button
                id="open-modal"
                class="rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950"
            >
                Open modal
            </button>

            <div
                id="modal"
                class="fixed inset-0 z-50 hidden items-center justify-center p-6"
            >
                <div
                    id="modal-backdrop"
                    class="absolute inset-0 bg-slate-950/60 backdrop-blur-sm"
                ></div>

                <div class="relative z-10 w-full max-w-md rounded-3xl bg-white p-7 shadow-2xl">
                    <h2 class="text-2xl font-extrabold text-slate-950">
                        Modal title
                    </h2>

                    <p class="mt-3 text-sm leading-6 text-slate-500">
                        Reusable modal content goes here.
                    </p>

                    <button
                        id="close-modal"
                        class="mt-6 rounded-xl bg-slate-950 px-5 py-3 text-sm font-bold text-white"
                    >
                        Close
                    </button>
                </div>
            </div>
            """,
            Css = """
            body.modal-open {
                overflow: hidden;
            }
            """,
            JavaScript = """
            const openButton = document.getElementById("open-modal");
            const closeButton = document.getElementById("close-modal");
            const modal = document.getElementById("modal");
            const backdrop = document.getElementById("modal-backdrop");

            function openModal() {
                modal.classList.remove("hidden");
                modal.classList.add("flex");
                document.body.classList.add("modal-open");
            }

            function closeModal() {
                modal.classList.add("hidden");
                modal.classList.remove("flex");
                document.body.classList.remove("modal-open");
            }

            openButton.addEventListener("click", openModal);
            closeButton.addEventListener("click", closeModal);
            backdrop.addEventListener("click", closeModal);

            window.addEventListener("keydown", event => {
                if (event.key === "Escape") {
                    closeModal();
                }
            });
            """
        },

        new Recipe
        {
            Id = 69,
            Name = "Interactive Dropdown",
            Category = "JavaScript UI",
            Description = "Dropdown menu with outside-click and Escape handling.",
            Accent = "emerald",
            Preview = """
            <div class="relative inline-block">
                <button class="rounded-xl border border-slate-200 bg-white px-5 py-3 text-sm font-bold text-slate-700 shadow-sm">
                    Actions
                </button>
                <div class="mt-2 w-56 rounded-2xl border border-slate-200 bg-white p-2 shadow-xl shadow-slate-200/70">
                    <div class="rounded-lg px-3 py-2 text-sm font-semibold text-slate-700">
                        Edit project
                    </div>
                    <div class="rounded-lg px-3 py-2 text-sm font-semibold text-slate-700">
                        Duplicate
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="relative inline-block">
                <button
                    id="dropdown-trigger"
                    class="rounded-xl border border-slate-200 bg-white px-5 py-3 text-sm font-bold text-slate-700"
                >
                    Actions
                </button>

                <div
                    id="dropdown-menu"
                    class="absolute right-0 top-full z-20 mt-2 hidden w-56 rounded-2xl border border-slate-200 bg-white p-2 shadow-xl shadow-slate-200/70"
                >
                    <button class="w-full rounded-lg px-3 py-2.5 text-left text-sm font-semibold text-slate-700 hover:bg-slate-100">
                        Edit project
                    </button>

                    <button class="w-full rounded-lg px-3 py-2.5 text-left text-sm font-semibold text-slate-700 hover:bg-slate-100">
                        Duplicate
                    </button>

                    <div class="my-1 border-t border-slate-100"></div>

                    <button class="w-full rounded-lg px-3 py-2.5 text-left text-sm font-semibold text-rose-600 hover:bg-rose-50">
                        Delete
                    </button>
                </div>
            </div>
            """,
            Css = """
            #dropdown-menu {
                transform-origin: top right;
            }
            """,
            JavaScript = """
            const trigger = document.getElementById("dropdown-trigger");
            const menu = document.getElementById("dropdown-menu");

            function closeDropdown() {
                menu.classList.add("hidden");
            }

            trigger.addEventListener("click", event => {
                event.stopPropagation();
                menu.classList.toggle("hidden");
            });

            menu.addEventListener("click", event => {
                event.stopPropagation();
            });

            document.addEventListener("click", closeDropdown);

            window.addEventListener("keydown", event => {
                if (event.key === "Escape") {
                    closeDropdown();
                }
            });
            """
        },

        new Recipe
        {
            Id = 70,
            Name = "Working Tabs",
            Category = "JavaScript UI",
            Description = "Accessible tab switcher with reusable active states.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-5">
                <div class="inline-flex rounded-xl bg-slate-100 p-1">
                    <button class="rounded-lg bg-white px-4 py-2 text-xs font-bold text-cyan-600 shadow-sm">
                        Preview
                    </button>
                    <button class="rounded-lg px-4 py-2 text-xs font-bold text-slate-500">
                        Code
                    </button>
                </div>
                <div class="mt-5 rounded-xl bg-cyan-50 p-5 text-sm font-semibold text-cyan-800">
                    Preview content
                </div>
            </div>
            """,
            Code = """
            <div>
                <div class="inline-flex rounded-xl bg-slate-100 p-1">
                    <button
                        data-tab="preview"
                        class="tab-button rounded-lg bg-white px-4 py-2 text-xs font-bold text-cyan-600 shadow-sm"
                    >
                        Preview
                    </button>

                    <button
                        data-tab="code"
                        class="tab-button rounded-lg px-4 py-2 text-xs font-bold text-slate-500"
                    >
                        Code
                    </button>

                    <button
                        data-tab="settings"
                        class="tab-button rounded-lg px-4 py-2 text-xs font-bold text-slate-500"
                    >
                        Settings
                    </button>
                </div>

                <div class="mt-5">
                    <div data-panel="preview">
                        Preview content
                    </div>

                    <div data-panel="code" class="hidden">
                        Code content
                    </div>

                    <div data-panel="settings" class="hidden">
                        Settings content
                    </div>
                </div>
            </div>
            """,
            Css = """
            .tab-button {
                transition:
                    background-color 160ms ease,
                    color 160ms ease,
                    box-shadow 160ms ease;
            }
            """,
            JavaScript = """
            const buttons = document.querySelectorAll("[data-tab]");
            const panels = document.querySelectorAll("[data-panel]");

            buttons.forEach(button => {
                button.addEventListener("click", () => {
                    const selectedTab = button.dataset.tab;

                    buttons.forEach(item => {
                        item.classList.remove(
                            "bg-white",
                            "text-cyan-600",
                            "shadow-sm"
                        );

                        item.classList.add("text-slate-500");
                    });

                    button.classList.add(
                        "bg-white",
                        "text-cyan-600",
                        "shadow-sm"
                    );

                    button.classList.remove("text-slate-500");

                    panels.forEach(panel => {
                        panel.classList.toggle(
                            "hidden",
                            panel.dataset.panel !== selectedTab
                        );
                    });
                });
            });
            """
        },

        new Recipe
        {
            Id = 71,
            Name = "Password Toggle",
            Category = "JavaScript UI",
            Description = "Password field with show and hide functionality.",
            Accent = "emerald",
            Preview = """
            <div class="w-full max-w-sm">
                <label class="mb-2 block text-sm font-bold text-slate-700">
                    Password
                </label>
                <div class="flex overflow-hidden rounded-xl border border-slate-300 bg-white">
                    <input
                        type="password"
                        value="supersecret"
                        class="min-w-0 flex-1 px-4 py-3 text-sm outline-none"
                    >
                    <button class="border-l border-slate-200 px-4 text-xs font-bold text-emerald-600">
                        Show
                    </button>
                </div>
            </div>
            """,
            Code = """
            <label class="block">
                <span class="mb-2 block text-sm font-bold text-slate-700">
                    Password
                </span>

                <div class="flex overflow-hidden rounded-xl border border-slate-300 bg-white focus-within:border-cyan-400 focus-within:ring-4 focus-within:ring-cyan-100">
                    <input
                        id="password-input"
                        type="password"
                        class="min-w-0 flex-1 px-4 py-3 text-sm outline-none"
                    >

                    <button
                        id="password-toggle"
                        type="button"
                        class="border-l border-slate-200 px-4 text-xs font-bold text-cyan-600"
                    >
                        Show
                    </button>
                </div>
            </label>
            """,
            Css = """
            #password-toggle {
                min-width: 72px;
            }
            """,
            JavaScript = """
            const input = document.getElementById("password-input");
            const toggle = document.getElementById("password-toggle");

            toggle.addEventListener("click", () => {
                const isHidden = input.type === "password";

                input.type = isHidden
                    ? "text"
                    : "password";

                toggle.textContent = isHidden
                    ? "Hide"
                    : "Show";
            });
            """
        },

        new Recipe
        {
            Id = 72,
            Name = "Copy Button",
            Category = "JavaScript Utilities",
            Description = "Reusable clipboard button with copied feedback.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-center justify-between gap-4 rounded-2xl bg-slate-950 p-5">
                <code class="font-mono text-xs text-slate-300">
                    npm install tailwindcss
                </code>
                <button class="rounded-lg bg-cyan-400 px-4 py-2 text-xs font-bold text-slate-950">
                    Copy
                </button>
            </div>
            """,
            Code = """
            <div class="flex items-center justify-between gap-4 rounded-2xl bg-slate-950 p-5">
                <code
                    id="copy-value"
                    class="font-mono text-xs text-slate-300"
                >
                    npm install tailwindcss
                </code>

                <button
                    id="copy-button"
                    class="rounded-lg bg-cyan-400 px-4 py-2 text-xs font-bold text-slate-950"
                >
                    Copy
                </button>
            </div>
            """,
            Css = """
            #copy-button {
                min-width: 72px;
            }
            """,
            JavaScript = """
            const value = document.getElementById("copy-value");
            const button = document.getElementById("copy-button");

            button.addEventListener("click", async () => {
                await navigator.clipboard.writeText(
                    value.textContent.trim()
                );

                button.textContent = "Copied";

                setTimeout(() => {
                    button.textContent = "Copy";
                }, 1200);
            });
            """
        },

        new Recipe
        {
            Id = 73,
            Name = "Interactive Toast",
            Category = "JavaScript UI",
            Description = "Show and automatically dismiss a toast notification.",
            Accent = "emerald",
            Preview = """
            <div class="w-full max-w-sm rounded-2xl border border-emerald-200 bg-white p-4 shadow-xl shadow-slate-200/70">
                <div class="flex items-start gap-3">
                    <div class="flex size-9 items-center justify-center rounded-xl bg-emerald-100 font-bold text-emerald-700">
                        ✓
                    </div>
                    <div>
                        <div class="text-sm font-bold text-slate-900">
                            Project saved
                        </div>
                        <p class="mt-1 text-xs text-slate-500">
                            Changes saved successfully.
                        </p>
                    </div>
                </div>
            </div>
            """,
            Code = """
            <button
                id="show-toast"
                class="rounded-xl bg-emerald-400 px-5 py-3 text-sm font-bold text-slate-950"
            >
                Save project
            </button>

            <div
                id="toast"
                class="fixed bottom-6 right-6 hidden w-full max-w-sm rounded-2xl border border-emerald-200 bg-white p-4 shadow-2xl"
            >
                <div class="flex items-start gap-3">
                    <div class="flex size-9 items-center justify-center rounded-xl bg-emerald-100 font-bold text-emerald-700">
                        ✓
                    </div>

                    <div>
                        <div class="text-sm font-bold text-slate-900">
                            Project saved
                        </div>

                        <p class="mt-1 text-xs text-slate-500">
                            Your changes were saved successfully.
                        </p>
                    </div>
                </div>
            </div>
            """,
            Css = """
            #toast {
                animation: toast-in 220ms ease-out;
            }

            @keyframes toast-in {
                from {
                    opacity: 0;
                    transform: translateY(16px);
                }

                to {
                    opacity: 1;
                    transform: translateY(0);
                }
            }
            """,
            JavaScript = """
            const button = document.getElementById("show-toast");
            const toast = document.getElementById("toast");

            let timeout;

            button.addEventListener("click", () => {
                clearTimeout(timeout);

                toast.classList.remove("hidden");

                timeout = setTimeout(() => {
                    toast.classList.add("hidden");
                }, 3000);
            });
            """
        },

        new Recipe
        {
            Id = 74,
            Name = "Character Counter",
            Category = "JavaScript Utilities",
            Description = "Textarea with live character count and maximum length.",
            Accent = "cyan",
            Preview = """
            <div class="w-full">
                <textarea
                    rows="3"
                    placeholder="Write something..."
                    class="w-full resize-none rounded-xl border border-slate-300 p-4 text-sm outline-none"
                ></textarea>
                <div class="mt-2 text-right text-xs font-semibold text-slate-400">
                    0 / 120
                </div>
            </div>
            """,
            Code = """
            <div>
                <textarea
                    id="message"
                    maxlength="120"
                    rows="4"
                    placeholder="Write something..."
                    class="w-full resize-none rounded-xl border border-slate-300 p-4 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                ></textarea>

                <div
                    id="character-count"
                    class="mt-2 text-right text-xs font-semibold text-slate-400"
                >
                    0 / 120
                </div>
            </div>
            """,
            Css = """
            #character-count.limit-close {
                color: rgb(244 63 94);
            }
            """,
            JavaScript = """
            const textarea = document.getElementById("message");
            const counter = document.getElementById("character-count");
            const limit = textarea.maxLength;

            function updateCount() {
                const count = textarea.value.length;

                counter.textContent = `${count} / ${limit}`;

                counter.classList.toggle(
                    "limit-close",
                    count >= limit - 20
                );
            }

            textarea.addEventListener(
                "input",
                updateCount
            );

            updateCount();
            """
        },

        new Recipe
        {
            Id = 75,
            Name = "Dismissible Alert",
            Category = "JavaScript UI",
            Description = "Alert component that can be dismissed by the user.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full items-start justify-between gap-5 rounded-2xl border border-cyan-200 bg-cyan-50 p-5">
                <div>
                    <div class="font-bold text-cyan-900">
                        Update available
                    </div>
                    <p class="mt-1 text-sm text-cyan-700">
                        A newer version is ready.
                    </p>
                </div>
                <button class="text-lg text-cyan-700">
                    ×
                </button>
            </div>
            """,
            Code = """
            <div
                id="alert"
                class="flex items-start justify-between gap-5 rounded-2xl border border-cyan-200 bg-cyan-50 p-5"
            >
                <div>
                    <div class="font-bold text-cyan-900">
                        Update available
                    </div>

                    <p class="mt-1 text-sm text-cyan-700">
                        A newer version is ready to install.
                    </p>
                </div>

                <button
                    id="dismiss-alert"
                    type="button"
                    class="flex size-8 items-center justify-center rounded-lg text-lg text-cyan-700 transition hover:bg-cyan-100"
                >
                    ×
                </button>
            </div>
            """,
            Css = """
            #alert {
                transition:
                    opacity 180ms ease,
                    transform 180ms ease;
            }

            #alert.is-leaving {
                opacity: 0;
                transform: translateY(-8px);
            }
            """,
            JavaScript = """
            const alert = document.getElementById("alert");
            const dismiss = document.getElementById("dismiss-alert");

            dismiss.addEventListener("click", () => {
                alert.classList.add("is-leaving");

                setTimeout(() => {
                    alert.remove();
                }, 180);
            });
            """
        }
    ];
}