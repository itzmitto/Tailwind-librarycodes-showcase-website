public static class SidebarRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 186,
            Name = "Clean Sidebar",
            Category = "Sidebars",
            Description = "Simple application sidebar with active navigation state.",
            Accent = "cyan",
            Preview = """
            <div class="w-64 rounded-2xl border border-slate-200 bg-white p-3">
                <div class="px-3 py-4 text-sm font-extrabold text-slate-950">
                    Workspace
                </div>

                <div class="space-y-1">
                    <button class="w-full rounded-xl bg-cyan-50 px-3 py-2.5 text-left text-sm font-bold text-cyan-700">
                        Dashboard
                    </button>

                    <button class="w-full rounded-xl px-3 py-2.5 text-left text-sm font-semibold text-slate-500 hover:bg-slate-50">
                        Projects
                    </button>

                    <button class="w-full rounded-xl px-3 py-2.5 text-left text-sm font-semibold text-slate-500 hover:bg-slate-50">
                        Settings
                    </button>
                </div>
            </div>
            """,
            Code = """
            <aside class="w-64 rounded-2xl border border-slate-200 bg-white p-3">
                <div class="px-3 py-4 text-sm font-extrabold text-slate-950">
                    Workspace
                </div>

                <nav class="space-y-1">
                    <a href="#" class="block rounded-xl bg-cyan-50 px-3 py-2.5 text-sm font-bold text-cyan-700">
                        Dashboard
                    </a>

                    <a href="#" class="block rounded-xl px-3 py-2.5 text-sm font-semibold text-slate-500 hover:bg-slate-50">
                        Projects
                    </a>

                    <a href="#" class="block rounded-xl px-3 py-2.5 text-sm font-semibold text-slate-500 hover:bg-slate-50">
                        Settings
                    </a>
                </nav>
            </aside>
            """
        },

        new Recipe
        {
            Id = 187,
            Name = "Dark Sidebar",
            Category = "Sidebars",
            Description = "Dark dashboard sidebar with cyan active state.",
            Accent = "cyan",
            Preview = """
            <div class="w-64 rounded-2xl bg-slate-950 p-3">
                <div class="px-3 py-4 font-bold text-white">
                    Control
                </div>

                <div class="space-y-1">
                    <div class="rounded-xl border border-cyan-400/20 bg-cyan-400/10 px-3 py-2.5 text-sm font-bold text-cyan-300">
                        Overview
                    </div>

                    <div class="rounded-xl px-3 py-2.5 text-sm font-semibold text-slate-500">
                        Analytics
                    </div>

                    <div class="rounded-xl px-3 py-2.5 text-sm font-semibold text-slate-500">
                        Deployments
                    </div>
                </div>
            </div>
            """,
            Code = """
            <aside class="w-64 rounded-2xl bg-slate-950 p-3">
                <div class="px-3 py-4 font-bold text-white">
                    Control
                </div>

                <nav class="space-y-1">
                    <a href="#" class="block rounded-xl border border-cyan-400/20 bg-cyan-400/10 px-3 py-2.5 text-sm font-bold text-cyan-300">
                        Overview
                    </a>

                    <a href="#" class="block rounded-xl px-3 py-2.5 text-sm font-semibold text-slate-500 hover:bg-white/5 hover:text-slate-300">
                        Analytics
                    </a>

                    <a href="#" class="block rounded-xl px-3 py-2.5 text-sm font-semibold text-slate-500 hover:bg-white/5 hover:text-slate-300">
                        Deployments
                    </a>
                </nav>
            </aside>
            """
        },

        new Recipe
        {
            Id = 188,
            Name = "Icon Sidebar",
            Category = "Sidebars",
            Description = "Compact vertical sidebar using icon-style navigation.",
            Accent = "emerald",
            Preview = """
            <div class="inline-flex flex-col gap-2 rounded-2xl border border-slate-200 bg-white p-2">
                <button class="flex size-11 items-center justify-center rounded-xl bg-emerald-400 font-bold text-slate-950">
                    H
                </button>

                <button class="flex size-11 items-center justify-center rounded-xl text-sm font-bold text-slate-400 hover:bg-slate-100">
                    P
                </button>

                <button class="flex size-11 items-center justify-center rounded-xl text-sm font-bold text-slate-400 hover:bg-slate-100">
                    S
                </button>
            </div>
            """,
            Code = """
            <aside class="inline-flex flex-col gap-2 rounded-2xl border border-slate-200 bg-white p-2">
                <button class="flex size-11 items-center justify-center rounded-xl bg-emerald-400 font-bold text-slate-950">
                    H
                </button>

                <button class="flex size-11 items-center justify-center rounded-xl text-sm font-bold text-slate-400 hover:bg-slate-100">
                    P
                </button>

                <button class="flex size-11 items-center justify-center rounded-xl text-sm font-bold text-slate-400 hover:bg-slate-100">
                    S
                </button>
            </aside>
            """
        },

        new Recipe
        {
            Id = 189,
            Name = "Project Sidebar",
            Category = "Sidebars",
            Description = "Sidebar combining project navigation and project status.",
            Accent = "cyan",
            Preview = """
            <div class="w-64 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="rounded-xl bg-slate-950 p-4">
                    <div class="text-[10px] font-bold uppercase tracking-widest text-cyan-400">
                        Project
                    </div>
                    <div class="mt-2 text-sm font-bold text-white">
                        Recipe Lab
                    </div>
                    <div class="mt-1 text-[10px] text-emerald-400">
                        Active
                    </div>
                </div>

                <div class="mt-4 space-y-1">
                    <div class="rounded-lg bg-cyan-50 px-3 py-2 text-xs font-bold text-cyan-700">
                        Components
                    </div>
                    <div class="rounded-lg px-3 py-2 text-xs font-semibold text-slate-500">
                        Deployments
                    </div>
                    <div class="rounded-lg px-3 py-2 text-xs font-semibold text-slate-500">
                        Settings
                    </div>
                </div>
            </div>
            """,
            Code = """
            <aside class="w-64 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="rounded-xl bg-slate-950 p-4">
                    <div class="text-[10px] font-bold uppercase tracking-widest text-cyan-400">
                        Project
                    </div>

                    <div class="mt-2 text-sm font-bold text-white">
                        Recipe Lab
                    </div>

                    <div class="mt-1 text-[10px] text-emerald-400">
                        Active
                    </div>
                </div>

                <nav class="mt-4 space-y-1">
                    <a href="#" class="block rounded-lg bg-cyan-50 px-3 py-2 text-xs font-bold text-cyan-700">
                        Components
                    </a>
                    <a href="#" class="block rounded-lg px-3 py-2 text-xs font-semibold text-slate-500">
                        Deployments
                    </a>
                </nav>
            </aside>
            """
        },

        new Recipe
        {
            Id = 190,
            Name = "Glass Sidebar",
            Category = "Sidebars",
            Description = "Glassmorphism navigation panel for colorful interfaces.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-3xl bg-gradient-to-br from-cyan-300 via-blue-300 to-emerald-300 p-6">
                <div class="w-56 rounded-2xl border border-white/50 bg-white/30 p-3 shadow-xl backdrop-blur-xl">
                    <div class="px-3 py-4 text-sm font-extrabold text-slate-950">
                        Glass Panel
                    </div>

                    <div class="space-y-1">
                        <div class="rounded-xl bg-white/50 px-3 py-2 text-xs font-bold text-slate-900">
                            Home
                        </div>
                        <div class="rounded-xl px-3 py-2 text-xs font-semibold text-slate-700">
                            Projects
                        </div>
                    </div>
                </div>
            </div>
            """,
            Code = """
            <aside class="w-56 rounded-2xl border border-white/50 bg-white/30 p-3 shadow-xl backdrop-blur-xl">
                <div class="px-3 py-4 text-sm font-extrabold text-slate-950">
                    Glass Panel
                </div>

                <nav class="space-y-1">
                    <a href="#" class="block rounded-xl bg-white/50 px-3 py-2 text-xs font-bold text-slate-900">
                        Home
                    </a>

                    <a href="#" class="block rounded-xl px-3 py-2 text-xs font-semibold text-slate-700">
                        Projects
                    </a>
                </nav>
            </aside>
            """
        }
    ];
}