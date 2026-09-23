public static class DataDisplayRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 156,
            Name = "Key Value List",
            Category = "Data Display",
            Description = "Clean key and value list for details and settings.",
            Accent = "cyan",
            Preview = """
            <div class="w-full divide-y divide-slate-100 rounded-2xl border border-slate-200 bg-white">
                <div class="flex justify-between px-5 py-4">
                    <span class="text-sm text-slate-400">Framework</span>
                    <span class="text-sm font-bold text-slate-900">React</span>
                </div>

                <div class="flex justify-between px-5 py-4">
                    <span class="text-sm text-slate-400">Language</span>
                    <span class="text-sm font-bold text-slate-900">TypeScript</span>
                </div>

                <div class="flex justify-between px-5 py-4">
                    <span class="text-sm text-slate-400">Status</span>
                    <span class="text-sm font-bold text-emerald-600">Active</span>
                </div>
            </div>
            """,
            Code = """
            <div class="divide-y divide-slate-100 rounded-2xl border border-slate-200 bg-white">
                <div class="flex justify-between px-5 py-4">
                    <span class="text-sm text-slate-400">Framework</span>
                    <span class="text-sm font-bold text-slate-900">React</span>
                </div>

                <div class="flex justify-between px-5 py-4">
                    <span class="text-sm text-slate-400">Language</span>
                    <span class="text-sm font-bold text-slate-900">TypeScript</span>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 157,
            Name = "Status Row",
            Category = "Data Display",
            Description = "Compact status row with indicator and metadata.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full items-center justify-between rounded-2xl border border-slate-200 bg-white p-5">
                <div class="flex items-center gap-3">
                    <span class="size-2.5 rounded-full bg-emerald-400"></span>

                    <div>
                        <div class="text-sm font-bold text-slate-900">
                            Production API
                        </div>

                        <div class="mt-1 text-xs text-slate-400">
                            eu-west-1
                        </div>
                    </div>
                </div>

                <span class="text-xs font-bold text-emerald-600">
                    Operational
                </span>
            </div>
            """,
            Code = """
            <div class="flex items-center justify-between rounded-2xl border border-slate-200 bg-white p-5">
                <div class="flex items-center gap-3">
                    <span class="size-2.5 rounded-full bg-emerald-400"></span>

                    <div>
                        <div class="text-sm font-bold text-slate-900">
                            Production API
                        </div>

                        <div class="mt-1 text-xs text-slate-400">
                            eu-west-1
                        </div>
                    </div>
                </div>

                <span class="text-xs font-bold text-emerald-600">
                    Operational
                </span>
            </div>
            """
        },

        new Recipe
        {
            Id = 158,
            Name = "File Row",
            Category = "Data Display",
            Description = "Reusable file list item with metadata and action.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="flex size-11 items-center justify-center rounded-xl bg-cyan-100 font-mono text-xs font-bold text-cyan-700">
                    JS
                </div>

                <div class="min-w-0 flex-1">
                    <div class="truncate text-sm font-bold text-slate-900">
                        app.js
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        18.4 KB
                    </div>
                </div>

                <button class="text-xl text-slate-400">
                    ⋯
                </button>
            </div>
            """,
            Code = """
            <div class="flex items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="flex size-11 items-center justify-center rounded-xl bg-cyan-100 font-mono text-xs font-bold text-cyan-700">
                    JS
                </div>

                <div class="min-w-0 flex-1">
                    <div class="truncate text-sm font-bold text-slate-900">
                        app.js
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        18.4 KB
                    </div>
                </div>

                <button class="text-xl text-slate-400">
                    ⋯
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 159,
            Name = "Version Badge Row",
            Category = "Data Display",
            Description = "Version information with release status.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full items-center justify-between rounded-2xl border border-slate-200 bg-white p-5">
                <div>
                    <div class="text-sm font-extrabold text-slate-950">
                        Tailwind CSS
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        Framework dependency
                    </div>
                </div>

                <div class="flex items-center gap-2">
                    <span class="rounded-lg bg-slate-100 px-2.5 py-1.5 font-mono text-[10px] font-bold text-slate-600">
                        v4.3.3
                    </span>

                    <span class="rounded-full bg-emerald-100 px-2.5 py-1.5 text-[9px] font-bold text-emerald-700">
                        Latest
                    </span>
                </div>
            </div>
            """,
            Code = """
            <div class="flex items-center justify-between rounded-2xl border border-slate-200 bg-white p-5">
                <div>
                    <div class="text-sm font-extrabold text-slate-950">
                        Tailwind CSS
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        Framework dependency
                    </div>
                </div>

                <div class="flex items-center gap-2">
                    <span class="rounded-lg bg-slate-100 px-2.5 py-1.5 font-mono text-[10px] font-bold text-slate-600">
                        v4.3.3
                    </span>

                    <span class="rounded-full bg-emerald-100 px-2.5 py-1.5 text-[9px] font-bold text-emerald-700">
                        Latest
                    </span>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 160,
            Name = "API Endpoint",
            Category = "Data Display",
            Description = "API endpoint row for developer tools and documentation.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <span class="rounded-lg bg-emerald-100 px-3 py-1.5 font-mono text-[10px] font-bold text-emerald-700">
                    GET
                </span>

                <code class="min-w-0 flex-1 truncate font-mono text-xs text-slate-600">
                    /api/recipes
                </code>

                <span class="rounded-full bg-cyan-100 px-2.5 py-1 text-[9px] font-bold text-cyan-700">
                    200
                </span>
            </div>
            """,
            Code = """
            <div class="flex items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <span class="rounded-lg bg-emerald-100 px-3 py-1.5 font-mono text-[10px] font-bold text-emerald-700">
                    GET
                </span>

                <code class="min-w-0 flex-1 truncate font-mono text-xs text-slate-600">
                    /api/recipes
                </code>

                <span class="rounded-full bg-cyan-100 px-2.5 py-1 text-[9px] font-bold text-cyan-700">
                    200
                </span>
            </div>
            """
        }
    ];
}