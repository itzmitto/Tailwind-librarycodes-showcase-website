public static class InteractiveRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 29,
            Name = "Cyan Checkbox",
            Category = "Checkboxes",
            Description = "Clean checkbox with cyan checked state.",
            Accent = "cyan",
            Preview = """
            <label class="inline-flex cursor-pointer items-center gap-3">
                <input
                    type="checkbox"
                    checked
                    class="size-5 rounded border-slate-300 text-cyan-500 accent-cyan-400 focus:ring-cyan-300"
                >
                <span class="text-sm font-semibold text-slate-700">
                    Remember me
                </span>
            </label>
            """,
            Code = """
            <label class="inline-flex cursor-pointer items-center gap-3">
                <input
                    type="checkbox"
                    checked
                    class="size-5 rounded border-slate-300 text-cyan-500 accent-cyan-400 focus:ring-cyan-300"
                >
                <span class="text-sm font-semibold text-slate-700">
                    Remember me
                </span>
            </label>
            """
        },

        new Recipe
        {
            Id = 30,
            Name = "Emerald Radio",
            Category = "Radio",
            Description = "Reusable radio option with emerald accent.",
            Accent = "emerald",
            Preview = """
            <div class="grid gap-3">
                <label class="flex cursor-pointer items-center gap-3 rounded-xl border border-emerald-300 bg-emerald-50 p-4">
                    <input
                        type="radio"
                        name="plan"
                        checked
                        class="size-4 accent-emerald-400"
                    >
                    <span>
                        <span class="block text-sm font-bold text-slate-900">
                            Pro plan
                        </span>
                        <span class="mt-1 block text-xs text-slate-500">
                            Advanced project features
                        </span>
                    </span>
                </label>
            </div>
            """,
            Code = """
            <label class="flex cursor-pointer items-center gap-3 rounded-xl border border-emerald-300 bg-emerald-50 p-4">
                <input
                    type="radio"
                    name="plan"
                    checked
                    class="size-4 accent-emerald-400"
                >
                <span>
                    <span class="block text-sm font-bold text-slate-900">
                        Pro plan
                    </span>
                    <span class="mt-1 block text-xs text-slate-500">
                        Advanced project features
                    </span>
                </span>
            </label>
            """
        },

        new Recipe
        {
            Id = 31,
            Name = "Clean Select",
            Category = "Selects",
            Description = "Clean select field for forms and settings.",
            Accent = "cyan",
            Preview = """
            <label class="block">
                <span class="mb-2 block text-sm font-semibold text-slate-700">
                    Framework
                </span>
                <select class="w-full rounded-xl border border-slate-300 bg-white px-4 py-3 text-sm text-slate-700 outline-none transition focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100">
                    <option>React</option>
                    <option>Next.js</option>
                    <option>Vue</option>
                    <option>Astro</option>
                </select>
            </label>
            """,
            Code = """
            <label class="block">
                <span class="mb-2 block text-sm font-semibold text-slate-700">
                    Framework
                </span>
                <select class="w-full rounded-xl border border-slate-300 bg-white px-4 py-3 text-sm text-slate-700 outline-none transition focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100">
                    <option>React</option>
                    <option>Next.js</option>
                    <option>Vue</option>
                    <option>Astro</option>
                </select>
            </label>
            """
        },

        new Recipe
        {
            Id = 32,
            Name = "Range Slider",
            Category = "Controls",
            Description = "Minimal cyan range input for settings panels.",
            Accent = "cyan",
            Preview = """
            <div class="w-full">
                <div class="mb-3 flex items-center justify-between">
                    <span class="text-sm font-bold text-slate-700">
                        Intensity
                    </span>
                    <span class="rounded-lg bg-cyan-100 px-2 py-1 text-xs font-bold text-cyan-700">
                        70%
                    </span>
                </div>
                <input
                    type="range"
                    min="0"
                    max="100"
                    value="70"
                    class="w-full accent-cyan-400"
                >
            </div>
            """,
            Code = """
            <input
                type="range"
                min="0"
                max="100"
                value="70"
                class="w-full accent-cyan-400"
            >
            """
        },

        new Recipe
        {
            Id = 33,
            Name = "Hover Tooltip",
            Category = "Tooltips",
            Description = "Pure Tailwind tooltip shown on hover.",
            Accent = "cyan",
            Preview = """
            <div class="group relative inline-flex">
                <button class="rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Hover me
                </button>
                <div class="pointer-events-none absolute bottom-full left-1/2 mb-3 -translate-x-1/2 translate-y-1 rounded-lg bg-slate-950 px-3 py-2 text-xs font-medium whitespace-nowrap text-white opacity-0 transition group-hover:translate-y-0 group-hover:opacity-100">
                    Helpful information
                </div>
            </div>
            """,
            Code = """
            <div class="group relative inline-flex">
                <button class="rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Hover me
                </button>
                <div class="pointer-events-none absolute bottom-full left-1/2 mb-3 -translate-x-1/2 translate-y-1 rounded-lg bg-slate-950 px-3 py-2 text-xs font-medium whitespace-nowrap text-white opacity-0 transition group-hover:translate-y-0 group-hover:opacity-100">
                    Helpful information
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 34,
            Name = "Dropdown Menu",
            Category = "Dropdowns",
            Description = "Compact dropdown surface for actions.",
            Accent = "cyan",
            Preview = """
            <div class="w-56 rounded-2xl border border-slate-200 bg-white p-2 shadow-xl shadow-slate-200/70">
                <button class="w-full rounded-lg px-3 py-2.5 text-left text-sm font-semibold text-slate-700 transition hover:bg-slate-100">
                    Edit project
                </button>
                <button class="w-full rounded-lg px-3 py-2.5 text-left text-sm font-semibold text-slate-700 transition hover:bg-slate-100">
                    Duplicate
                </button>
                <div class="my-1 border-t border-slate-100"></div>
                <button class="w-full rounded-lg px-3 py-2.5 text-left text-sm font-semibold text-rose-600 transition hover:bg-rose-50">
                    Delete
                </button>
            </div>
            """,
            Code = """
            <div class="w-56 rounded-2xl border border-slate-200 bg-white p-2 shadow-xl shadow-slate-200/70">
                <button class="w-full rounded-lg px-3 py-2.5 text-left text-sm font-semibold text-slate-700 transition hover:bg-slate-100">
                    Edit project
                </button>
                <button class="w-full rounded-lg px-3 py-2.5 text-left text-sm font-semibold text-slate-700 transition hover:bg-slate-100">
                    Duplicate
                </button>
                <div class="my-1 border-t border-slate-100"></div>
                <button class="w-full rounded-lg px-3 py-2.5 text-left text-sm font-semibold text-rose-600 transition hover:bg-rose-50">
                    Delete
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 35,
            Name = "Cyan Tabs",
            Category = "Tabs",
            Description = "Simple horizontal tabs with active cyan state.",
            Accent = "cyan",
            Preview = """
            <div class="inline-flex rounded-xl bg-slate-100 p-1">
                <button class="rounded-lg bg-white px-4 py-2 text-xs font-bold text-cyan-600 shadow-sm">
                    Preview
                </button>
                <button class="rounded-lg px-4 py-2 text-xs font-bold text-slate-500 transition hover:text-slate-900">
                    Code
                </button>
                <button class="rounded-lg px-4 py-2 text-xs font-bold text-slate-500 transition hover:text-slate-900">
                    Settings
                </button>
            </div>
            """,
            Code = """
            <div class="inline-flex rounded-xl bg-slate-100 p-1">
                <button class="rounded-lg bg-white px-4 py-2 text-xs font-bold text-cyan-600 shadow-sm">
                    Preview
                </button>
                <button class="rounded-lg px-4 py-2 text-xs font-bold text-slate-500 transition hover:text-slate-900">
                    Code
                </button>
                <button class="rounded-lg px-4 py-2 text-xs font-bold text-slate-500 transition hover:text-slate-900">
                    Settings
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 36,
            Name = "FAQ Accordion",
            Category = "Accordions",
            Description = "Native details element styled as an accordion.",
            Accent = "emerald",
            Preview = """
            <details class="group w-full rounded-2xl border border-slate-200 bg-white p-5">
                <summary class="flex cursor-pointer list-none items-center justify-between gap-4 font-bold text-slate-900">
                    Can I use this in React?
                    <span class="text-xl text-emerald-500 transition group-open:rotate-45">
                        +
                    </span>
                </summary>
                <p class="mt-4 border-t border-slate-100 pt-4 text-sm leading-6 text-slate-500">
                    Yes. Copy the Tailwind classes into your JSX and change class to className.
                </p>
            </details>
            """,
            Code = """
            <details class="group rounded-2xl border border-slate-200 bg-white p-5">
                <summary class="flex cursor-pointer list-none items-center justify-between gap-4 font-bold text-slate-900">
                    Can I use this in React?
                    <span class="text-xl text-emerald-500 transition group-open:rotate-45">
                        +
                    </span>
                </summary>
                <p class="mt-4 border-t border-slate-100 pt-4 text-sm leading-6 text-slate-500">
                    Yes. Copy the Tailwind classes into your JSX and change class to className.
                </p>
            </details>
            """
        },

        new Recipe
        {
            Id = 37,
            Name = "Confirmation Modal",
            Category = "Modals",
            Description = "Compact confirmation dialog surface.",
            Accent = "cyan",
            Preview = """
            <div class="w-full max-w-sm rounded-3xl border border-slate-200 bg-white p-6 shadow-2xl shadow-slate-300/60">
                <div class="flex size-11 items-center justify-center rounded-xl bg-cyan-100 font-bold text-cyan-700">
                    ?
                </div>
                <h3 class="mt-5 text-xl font-extrabold tracking-tight text-slate-950">
                    Publish project?
                </h3>
                <p class="mt-2 text-sm leading-6 text-slate-500">
                    Your latest changes will become publicly available.
                </p>
                <div class="mt-6 flex justify-end gap-2">
                    <button class="rounded-xl px-4 py-2.5 text-sm font-bold text-slate-600 hover:bg-slate-100">
                        Cancel
                    </button>
                    <button class="rounded-xl bg-cyan-400 px-4 py-2.5 text-sm font-bold text-slate-950 hover:bg-cyan-300">
                        Publish
                    </button>
                </div>
            </div>
            """,
            Code = """
            <div class="w-full max-w-sm rounded-3xl border border-slate-200 bg-white p-6 shadow-2xl shadow-slate-300/60">
                <div class="flex size-11 items-center justify-center rounded-xl bg-cyan-100 font-bold text-cyan-700">
                    ?
                </div>
                <h3 class="mt-5 text-xl font-extrabold tracking-tight text-slate-950">
                    Publish project?
                </h3>
                <p class="mt-2 text-sm leading-6 text-slate-500">
                    Your latest changes will become publicly available.
                </p>
                <div class="mt-6 flex justify-end gap-2">
                    <button class="rounded-xl px-4 py-2.5 text-sm font-bold text-slate-600 hover:bg-slate-100">
                        Cancel
                    </button>
                    <button class="rounded-xl bg-cyan-400 px-4 py-2.5 text-sm font-bold text-slate-950 hover:bg-cyan-300">
                        Publish
                    </button>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 38,
            Name = "Success Toast",
            Category = "Toasts",
            Description = "Emerald notification toast for successful actions.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full max-w-sm items-start gap-4 rounded-2xl border border-emerald-200 bg-white p-4 shadow-xl shadow-slate-200/60">
                <div class="flex size-9 shrink-0 items-center justify-center rounded-xl bg-emerald-100 font-bold text-emerald-700">
                    ✓
                </div>
                <div>
                    <div class="text-sm font-bold text-slate-900">
                        Project saved
                    </div>
                    <p class="mt-1 text-xs leading-5 text-slate-500">
                        Your latest changes were saved successfully.
                    </p>
                </div>
            </div>
            """,
            Code = """
            <div class="flex w-full max-w-sm items-start gap-4 rounded-2xl border border-emerald-200 bg-white p-4 shadow-xl shadow-slate-200/60">
                <div class="flex size-9 shrink-0 items-center justify-center rounded-xl bg-emerald-100 font-bold text-emerald-700">
                    ✓
                </div>
                <div>
                    <div class="text-sm font-bold text-slate-900">
                        Project saved
                    </div>
                    <p class="mt-1 text-xs leading-5 text-slate-500">
                        Your latest changes were saved successfully.
                    </p>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 39,
            Name = "Pagination",
            Category = "Pagination",
            Description = "Clean pagination control with cyan active state.",
            Accent = "cyan",
            Preview = """
            <div class="inline-flex items-center gap-1">
                <button class="flex size-9 items-center justify-center rounded-lg border border-slate-200 text-sm font-bold text-slate-500 hover:bg-slate-50">
                    ←
                </button>
                <button class="flex size-9 items-center justify-center rounded-lg bg-cyan-400 text-sm font-bold text-slate-950">
                    1
                </button>
                <button class="flex size-9 items-center justify-center rounded-lg text-sm font-bold text-slate-500 hover:bg-slate-100">
                    2
                </button>
                <button class="flex size-9 items-center justify-center rounded-lg text-sm font-bold text-slate-500 hover:bg-slate-100">
                    3
                </button>
                <button class="flex size-9 items-center justify-center rounded-lg border border-slate-200 text-sm font-bold text-slate-500 hover:bg-slate-50">
                    →
                </button>
            </div>
            """,
            Code = """
            <div class="inline-flex items-center gap-1">
                <button class="flex size-9 items-center justify-center rounded-lg border border-slate-200 text-sm font-bold text-slate-500 hover:bg-slate-50">
                    ←
                </button>
                <button class="flex size-9 items-center justify-center rounded-lg bg-cyan-400 text-sm font-bold text-slate-950">
                    1
                </button>
                <button class="flex size-9 items-center justify-center rounded-lg text-sm font-bold text-slate-500 hover:bg-slate-100">
                    2
                </button>
                <button class="flex size-9 items-center justify-center rounded-lg text-sm font-bold text-slate-500 hover:bg-slate-100">
                    3
                </button>
                <button class="flex size-9 items-center justify-center rounded-lg border border-slate-200 text-sm font-bold text-slate-500 hover:bg-slate-50">
                    →
                </button>
            </div>
            """
        }
    ];
}