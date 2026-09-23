public static class DashboardRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 136,
            Name = "Revenue Widget",
            Category = "Dashboard",
            Description = "Clean revenue widget with positive trend indicator.",
            Accent = "emerald",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-start justify-between">
                    <div>
                        <div class="text-sm font-semibold text-slate-500">
                            Revenue
                        </div>
                        <div class="mt-3 text-4xl font-extrabold tracking-[-0.05em] text-slate-950">
                            €24.8K
                        </div>
                    </div>

                    <span class="rounded-full bg-emerald-100 px-3 py-1 text-xs font-bold text-emerald-700">
                        +18.4%
                    </span>
                </div>

                <div class="mt-6 flex h-14 items-end gap-1.5">
                    <div class="h-[35%] flex-1 rounded-t bg-cyan-100"></div>
                    <div class="h-[55%] flex-1 rounded-t bg-cyan-200"></div>
                    <div class="h-[42%] flex-1 rounded-t bg-cyan-200"></div>
                    <div class="h-[75%] flex-1 rounded-t bg-cyan-300"></div>
                    <div class="h-[62%] flex-1 rounded-t bg-cyan-300"></div>
                    <div class="h-full flex-1 rounded-t bg-cyan-400"></div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-start justify-between">
                    <div>
                        <div class="text-sm font-semibold text-slate-500">
                            Revenue
                        </div>
                        <div class="mt-3 text-4xl font-extrabold tracking-[-0.05em] text-slate-950">
                            €24.8K
                        </div>
                    </div>

                    <span class="rounded-full bg-emerald-100 px-3 py-1 text-xs font-bold text-emerald-700">
                        +18.4%
                    </span>
                </div>

                <div class="mt-6 flex h-14 items-end gap-1.5">
                    <div class="h-[35%] flex-1 rounded-t bg-cyan-100"></div>
                    <div class="h-[55%] flex-1 rounded-t bg-cyan-200"></div>
                    <div class="h-[42%] flex-1 rounded-t bg-cyan-200"></div>
                    <div class="h-[75%] flex-1 rounded-t bg-cyan-300"></div>
                    <div class="h-[62%] flex-1 rounded-t bg-cyan-300"></div>
                    <div class="h-full flex-1 rounded-t bg-cyan-400"></div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 137,
            Name = "Storage Widget",
            Category = "Dashboard",
            Description = "Storage usage widget with clean progress visualization.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-center justify-between">
                    <div class="text-sm font-bold text-slate-900">
                        Storage
                    </div>
                    <div class="text-xs font-semibold text-slate-400">
                        68 / 100 GB
                    </div>
                </div>

                <div class="mt-6 h-3 overflow-hidden rounded-full bg-slate-100">
                    <div class="h-full w-[68%] rounded-full bg-gradient-to-r from-cyan-400 to-emerald-400"></div>
                </div>

                <div class="mt-4 flex justify-between text-xs text-slate-400">
                    <span>68% used</span>
                    <span>32 GB free</span>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-center justify-between">
                    <div class="text-sm font-bold text-slate-900">
                        Storage
                    </div>
                    <div class="text-xs font-semibold text-slate-400">
                        68 / 100 GB
                    </div>
                </div>

                <div class="mt-6 h-3 overflow-hidden rounded-full bg-slate-100">
                    <div class="h-full w-[68%] rounded-full bg-gradient-to-r from-cyan-400 to-emerald-400"></div>
                </div>

                <div class="mt-4 flex justify-between text-xs text-slate-400">
                    <span>68% used</span>
                    <span>32 GB free</span>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 138,
            Name = "Activity Widget",
            Category = "Dashboard",
            Description = "Compact recent activity list for dashboards.",
            Accent = "emerald",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-5">
                <div class="mb-5 text-sm font-extrabold text-slate-950">
                    Recent activity
                </div>

                <div class="space-y-4">
                    <div class="flex items-center gap-3">
                        <div class="size-2 rounded-full bg-emerald-400"></div>
                        <div class="min-w-0 flex-1">
                            <div class="text-xs font-bold text-slate-800">
                                Deployment completed
                            </div>
                            <div class="mt-1 text-[10px] text-slate-400">
                                2 minutes ago
                            </div>
                        </div>
                    </div>

                    <div class="flex items-center gap-3">
                        <div class="size-2 rounded-full bg-cyan-400"></div>
                        <div class="min-w-0 flex-1">
                            <div class="text-xs font-bold text-slate-800">
                                New team member
                            </div>
                            <div class="mt-1 text-[10px] text-slate-400">
                                18 minutes ago
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-5">
                <div class="mb-5 text-sm font-extrabold text-slate-950">
                    Recent activity
                </div>

                <div class="space-y-4">
                    <div class="flex items-center gap-3">
                        <div class="size-2 rounded-full bg-emerald-400"></div>

                        <div>
                            <div class="text-xs font-bold text-slate-800">
                                Deployment completed
                            </div>
                            <div class="mt-1 text-[10px] text-slate-400">
                                2 minutes ago
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 139,
            Name = "Server Health",
            Category = "Dashboard",
            Description = "Server health panel with multiple system metrics.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl bg-slate-950 p-6">
                <div class="flex items-center justify-between">
                    <div class="text-sm font-bold text-white">
                        Server health
                    </div>

                    <span class="flex items-center gap-2 text-xs font-bold text-emerald-400">
                        <span class="size-2 rounded-full bg-emerald-400"></span>
                        Healthy
                    </span>
                </div>

                <div class="mt-6 grid grid-cols-3 gap-3">
                    <div class="rounded-xl bg-white/5 p-3 text-center">
                        <div class="text-[9px] uppercase tracking-wider text-slate-500">
                            CPU
                        </div>
                        <div class="mt-2 text-lg font-extrabold text-cyan-300">
                            42%
                        </div>
                    </div>

                    <div class="rounded-xl bg-white/5 p-3 text-center">
                        <div class="text-[9px] uppercase tracking-wider text-slate-500">
                            RAM
                        </div>
                        <div class="mt-2 text-lg font-extrabold text-emerald-300">
                            61%
                        </div>
                    </div>

                    <div class="rounded-xl bg-white/5 p-3 text-center">
                        <div class="text-[9px] uppercase tracking-wider text-slate-500">
                            DISK
                        </div>
                        <div class="mt-2 text-lg font-extrabold text-violet-300">
                            73%
                        </div>
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl bg-slate-950 p-6">
                <div class="flex items-center justify-between">
                    <div class="text-sm font-bold text-white">
                        Server health
                    </div>

                    <span class="flex items-center gap-2 text-xs font-bold text-emerald-400">
                        <span class="size-2 rounded-full bg-emerald-400"></span>
                        Healthy
                    </span>
                </div>

                <div class="mt-6 grid grid-cols-3 gap-3">
                    <div class="rounded-xl bg-white/5 p-3 text-center">
                        <div class="text-[9px] uppercase tracking-wider text-slate-500">
                            CPU
                        </div>
                        <div class="mt-2 text-lg font-extrabold text-cyan-300">
                            42%
                        </div>
                    </div>

                    <div class="rounded-xl bg-white/5 p-3 text-center">
                        <div class="text-[9px] uppercase tracking-wider text-slate-500">
                            RAM
                        </div>
                        <div class="mt-2 text-lg font-extrabold text-emerald-300">
                            61%
                        </div>
                    </div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 140,
            Name = "Mini Analytics",
            Category = "Dashboard",
            Description = "Small analytics metric with visual trend line.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-6">
                <div class="text-xs font-semibold text-slate-400">
                    Visitors
                </div>

                <div class="mt-2 flex items-end justify-between">
                    <div class="text-3xl font-extrabold text-slate-950">
                        14,280
                    </div>

                    <div class="text-xs font-bold text-emerald-600">
                        +9.2%
                    </div>
                </div>

                <div class="mt-6 flex h-10 items-end gap-1">
                    <div class="h-[30%] flex-1 rounded-sm bg-cyan-100"></div>
                    <div class="h-[42%] flex-1 rounded-sm bg-cyan-100"></div>
                    <div class="h-[38%] flex-1 rounded-sm bg-cyan-200"></div>
                    <div class="h-[62%] flex-1 rounded-sm bg-cyan-200"></div>
                    <div class="h-[55%] flex-1 rounded-sm bg-cyan-300"></div>
                    <div class="h-[80%] flex-1 rounded-sm bg-cyan-400"></div>
                    <div class="h-full flex-1 rounded-sm bg-emerald-400"></div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="text-xs font-semibold text-slate-400">
                    Visitors
                </div>

                <div class="mt-2 flex items-end justify-between">
                    <div class="text-3xl font-extrabold text-slate-950">
                        14,280
                    </div>

                    <div class="text-xs font-bold text-emerald-600">
                        +9.2%
                    </div>
                </div>
            </div>
            """
        }
    ];
}