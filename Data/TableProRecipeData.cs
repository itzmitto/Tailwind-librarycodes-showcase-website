public static class TableProRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 201,
            Name = "Project Table",
            Category = "Tables Pro",
            Description = "Project management table with status indicators.",
            Accent = "cyan",
            Preview = """
            <div class="w-full overflow-hidden rounded-2xl border border-slate-200 bg-white">
                <div class="grid grid-cols-[1fr_auto_auto] gap-4 border-b border-slate-200 bg-slate-50 px-5 py-3 text-[10px] font-bold uppercase tracking-wider text-slate-400">
                    <span>Project</span>
                    <span>Status</span>
                    <span>Updated</span>
                </div>

                <div class="grid grid-cols-[1fr_auto_auto] items-center gap-4 px-5 py-4">
                    <span class="text-sm font-bold text-slate-950">
                        Recipe Lab
                    </span>

                    <span class="rounded-full bg-emerald-100 px-2.5 py-1 text-[9px] font-bold text-emerald-700">
                        Active
                    </span>

                    <span class="text-xs text-slate-400">
                        Today
                    </span>
                </div>
            </div>
            """,
            Code = """
            <div class="overflow-hidden rounded-2xl border border-slate-200 bg-white">
                <table class="w-full text-left">
                    <thead class="border-b border-slate-200 bg-slate-50">
                        <tr>
                            <th class="px-5 py-3 text-[10px] font-bold uppercase tracking-wider text-slate-400">
                                Project
                            </th>
                            <th class="px-5 py-3 text-[10px] font-bold uppercase tracking-wider text-slate-400">
                                Status
                            </th>
                            <th class="px-5 py-3 text-[10px] font-bold uppercase tracking-wider text-slate-400">
                                Updated
                            </th>
                        </tr>
                    </thead>

                    <tbody>
                        <tr>
                            <td class="px-5 py-4 text-sm font-bold text-slate-950">
                                Recipe Lab
                            </td>
                            <td class="px-5 py-4">
                                <span class="rounded-full bg-emerald-100 px-2.5 py-1 text-[9px] font-bold text-emerald-700">
                                    Active
                                </span>
                            </td>
                            <td class="px-5 py-4 text-xs text-slate-400">
                                Today
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            """
        },

        new Recipe
        {
            Id = 202,
            Name = "Selectable Table Row",
            Category = "Tables Pro",
            Description = "Table row with checkbox selection.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-center gap-4 rounded-xl border border-cyan-200 bg-cyan-50/50 p-4">
                <input
                    type="checkbox"
                    checked
                    class="size-4 accent-cyan-500"
                >

                <div class="min-w-0 flex-1">
                    <div class="text-sm font-bold text-slate-950">
                        design-system
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        Updated 4 minutes ago
                    </div>
                </div>

                <span class="text-xs font-semibold text-slate-500">
                    18 files
                </span>
            </div>
            """,
            Code = """
            <div class="flex items-center gap-4 rounded-xl border border-cyan-200 bg-cyan-50/50 p-4">
                <input
                    type="checkbox"
                    class="size-4 accent-cyan-500"
                >

                <div class="min-w-0 flex-1">
                    <div class="text-sm font-bold text-slate-950">
                        design-system
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        Updated 4 minutes ago
                    </div>
                </div>

                <span class="text-xs font-semibold text-slate-500">
                    18 files
                </span>
            </div>
            """
        },

        new Recipe
        {
            Id = 203,
            Name = "Dark Data Table",
            Category = "Tables Pro",
            Description = "Dark table style for admin and developer dashboards.",
            Accent = "cyan",
            Preview = """
            <div class="w-full overflow-hidden rounded-2xl border border-white/10 bg-slate-950">
                <div class="grid grid-cols-3 border-b border-white/10 bg-white/5 px-5 py-3 text-[9px] font-bold uppercase tracking-wider text-slate-500">
                    <span>Service</span>
                    <span>Region</span>
                    <span>Status</span>
                </div>

                <div class="grid grid-cols-3 items-center px-5 py-4 text-xs">
                    <span class="font-bold text-white">
                        API
                    </span>
                    <span class="text-slate-500">
                        EU
                    </span>
                    <span class="font-bold text-emerald-400">
                        Online
                    </span>
                </div>
            </div>
            """,
            Code = """
            <table class="w-full overflow-hidden rounded-2xl bg-slate-950 text-left">
                <thead class="border-b border-white/10 bg-white/5">
                    <tr>
                        <th class="px-5 py-3 text-[9px] font-bold uppercase tracking-wider text-slate-500">
                            Service
                        </th>
                        <th class="px-5 py-3 text-[9px] font-bold uppercase tracking-wider text-slate-500">
                            Region
                        </th>
                        <th class="px-5 py-3 text-[9px] font-bold uppercase tracking-wider text-slate-500">
                            Status
                        </th>
                    </tr>
                </thead>

                <tbody>
                    <tr>
                        <td class="px-5 py-4 text-xs font-bold text-white">
                            API
                        </td>
                        <td class="px-5 py-4 text-xs text-slate-500">
                            EU
                        </td>
                        <td class="px-5 py-4 text-xs font-bold text-emerald-400">
                            Online
                        </td>
                    </tr>
                </tbody>
            </table>
            """
        },

        new Recipe
        {
            Id = 204,
            Name = "Compact Table",
            Category = "Tables Pro",
            Description = "Dense data table for administration interfaces.",
            Accent = "emerald",
            Preview = """
            <div class="w-full overflow-hidden rounded-xl border border-slate-200">
                <div class="grid grid-cols-3 bg-slate-50 px-3 py-2 text-[9px] font-bold text-slate-400">
                    <span>ID</span>
                    <span>TYPE</span>
                    <span>STATE</span>
                </div>

                <div class="grid grid-cols-3 border-t border-slate-100 px-3 py-2 text-[10px]">
                    <span class="font-mono text-slate-500">#1001</span>
                    <span class="font-semibold text-slate-700">Build</span>
                    <span class="font-bold text-emerald-600">Done</span>
                </div>

                <div class="grid grid-cols-3 border-t border-slate-100 px-3 py-2 text-[10px]">
                    <span class="font-mono text-slate-500">#1002</span>
                    <span class="font-semibold text-slate-700">Deploy</span>
                    <span class="font-bold text-cyan-600">Running</span>
                </div>
            </div>
            """,
            Code = """
            <div class="overflow-hidden rounded-xl border border-slate-200">
                <div class="grid grid-cols-3 bg-slate-50 px-3 py-2 text-[9px] font-bold text-slate-400">
                    <span>ID</span>
                    <span>TYPE</span>
                    <span>STATE</span>
                </div>

                <div class="grid grid-cols-3 border-t border-slate-100 px-3 py-2 text-[10px]">
                    <span class="font-mono text-slate-500">#1001</span>
                    <span class="font-semibold text-slate-700">Build</span>
                    <span class="font-bold text-emerald-600">Done</span>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 205,
            Name = "Table Action Row",
            Category = "Tables Pro",
            Description = "Data row with inline view and action controls.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="flex size-10 items-center justify-center rounded-xl bg-cyan-100 font-bold text-cyan-700">
                    A
                </div>

                <div class="min-w-0 flex-1">
                    <div class="text-sm font-bold text-slate-950">
                        API Server
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        Production
                    </div>
                </div>

                <button class="rounded-lg border border-slate-200 px-3 py-2 text-[10px] font-bold text-slate-500">
                    View
                </button>

                <button class="flex size-8 items-center justify-center rounded-lg bg-slate-100 font-bold text-slate-500">
                    ⋯
                </button>
            </div>
            """,
            Code = """
            <div class="flex items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="flex size-10 items-center justify-center rounded-xl bg-cyan-100 font-bold text-cyan-700">
                    A
                </div>

                <div class="min-w-0 flex-1">
                    <div class="text-sm font-bold text-slate-950">
                        API Server
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        Production
                    </div>
                </div>

                <button class="rounded-lg border border-slate-200 px-3 py-2 text-[10px] font-bold text-slate-500">
                    View
                </button>

                <button class="flex size-8 items-center justify-center rounded-lg bg-slate-100 font-bold text-slate-500">
                    ⋯
                </button>
            </div>
            """
        }
    ];
}