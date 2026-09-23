public static class InputProRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 169,
            Name = "Search With Shortcut",
            Category = "Inputs Pro",
            Description = "Search field with keyboard shortcut indicator.",
            Accent = "cyan",
            Preview = """
            <div class="relative w-full">
                <input
                    type="search"
                    placeholder="Search anything..."
                    class="w-full rounded-xl border border-slate-300 bg-white py-3 pl-4 pr-16 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >

                <kbd class="absolute right-3 top-1/2 -translate-y-1/2 rounded-md border border-slate-200 bg-slate-100 px-2 py-1 font-mono text-[9px] font-bold text-slate-500">
                    /
                </kbd>
            </div>
            """,
            Code = """
            <div class="relative">
                <input
                    type="search"
                    placeholder="Search anything..."
                    class="w-full rounded-xl border border-slate-300 bg-white py-3 pl-4 pr-16 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >

                <kbd class="absolute right-3 top-1/2 -translate-y-1/2 rounded-md border border-slate-200 bg-slate-100 px-2 py-1 font-mono text-[9px] font-bold text-slate-500">
                    /
                </kbd>
            </div>
            """
        },

        new Recipe
        {
            Id = 170,
            Name = "Input With Action",
            Category = "Inputs Pro",
            Description = "Input group with attached action button.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full overflow-hidden rounded-xl border border-slate-300 bg-white focus-within:border-emerald-400 focus-within:ring-4 focus-within:ring-emerald-100">
                <input
                    type="text"
                    placeholder="Paste URL..."
                    class="min-w-0 flex-1 px-4 py-3 text-sm outline-none"
                >

                <button class="border-l border-slate-200 bg-emerald-400 px-5 text-xs font-bold text-slate-950">
                    Import
                </button>
            </div>
            """,
            Code = """
            <div class="flex overflow-hidden rounded-xl border border-slate-300 bg-white focus-within:border-emerald-400 focus-within:ring-4 focus-within:ring-emerald-100">
                <input
                    type="text"
                    placeholder="Paste URL..."
                    class="min-w-0 flex-1 px-4 py-3 text-sm outline-none"
                >

                <button class="border-l border-slate-200 bg-emerald-400 px-5 text-xs font-bold text-slate-950">
                    Import
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 171,
            Name = "Success Input",
            Category = "Inputs Pro",
            Description = "Validated input field with success feedback.",
            Accent = "emerald",
            Preview = """
            <div class="w-full">
                <div class="relative">
                    <input
                        type="text"
                        value="andre"
                        class="w-full rounded-xl border border-emerald-400 bg-emerald-50/50 px-4 py-3 pr-12 text-sm text-slate-900 outline-none ring-4 ring-emerald-100"
                    >

                    <span class="absolute right-4 top-1/2 -translate-y-1/2 font-bold text-emerald-600">
                        ✓
                    </span>
                </div>

                <div class="mt-2 text-xs font-semibold text-emerald-600">
                    Username available
                </div>
            </div>
            """,
            Code = """
            <div>
                <div class="relative">
                    <input
                        type="text"
                        class="w-full rounded-xl border border-emerald-400 bg-emerald-50/50 px-4 py-3 pr-12 text-sm text-slate-900 outline-none ring-4 ring-emerald-100"
                    >

                    <span class="absolute right-4 top-1/2 -translate-y-1/2 font-bold text-emerald-600">
                        ✓
                    </span>
                </div>

                <div class="mt-2 text-xs font-semibold text-emerald-600">
                    Username available
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 172,
            Name = "Dark Search Input",
            Category = "Inputs Pro",
            Description = "Dark search field for dashboard and neon interfaces.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl bg-slate-950 p-6">
                <div class="relative">
                    <span class="absolute left-4 top-1/2 -translate-y-1/2 text-slate-500">
                        ⌕
                    </span>

                    <input
                        type="search"
                        placeholder="Search system..."
                        class="w-full rounded-xl border border-white/10 bg-white/5 py-3 pl-11 pr-4 text-sm text-white outline-none placeholder:text-slate-600 focus:border-cyan-400/60 focus:bg-cyan-400/5 focus:ring-4 focus:ring-cyan-400/10"
                    >
                </div>
            </div>
            """,
            Code = """
            <div class="relative">
                <span class="absolute left-4 top-1/2 -translate-y-1/2 text-slate-500">
                    ⌕
                </span>

                <input
                    type="search"
                    placeholder="Search system..."
                    class="w-full rounded-xl border border-white/10 bg-white/5 py-3 pl-11 pr-4 text-sm text-white outline-none placeholder:text-slate-600 focus:border-cyan-400/60 focus:bg-cyan-400/5 focus:ring-4 focus:ring-cyan-400/10"
                >
            </div>
            """
        }
    ];
}