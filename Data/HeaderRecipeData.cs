public static class HeaderRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 191,
            Name = "Dashboard Header",
            Category = "Headers",
            Description = "Dashboard header with title and primary action.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-center justify-between border-b border-slate-200 pb-5">
                <div>
                    <div class="text-2xl font-extrabold tracking-tight text-slate-950">
                        Dashboard
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        Manage your workspace.
                    </div>
                </div>

                <button class="rounded-xl bg-cyan-400 px-4 py-2.5 text-xs font-bold text-slate-950">
                    New project
                </button>
            </div>
            """,
            Code = """
            <header class="flex items-center justify-between border-b border-slate-200 pb-5">
                <div>
                    <h1 class="text-2xl font-extrabold tracking-tight text-slate-950">
                        Dashboard
                    </h1>

                    <p class="mt-1 text-xs text-slate-400">
                        Manage your workspace.
                    </p>
                </div>

                <button class="rounded-xl bg-cyan-400 px-4 py-2.5 text-xs font-bold text-slate-950">
                    New project
                </button>
            </header>
            """
        },

        new Recipe
        {
            Id = 192,
            Name = "Search Header",
            Category = "Headers",
            Description = "Application header with integrated search field.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="text-sm font-extrabold text-slate-950">
                    Workspace
                </div>

                <input
                    type="search"
                    placeholder="Search..."
                    class="min-w-0 flex-1 rounded-xl bg-slate-100 px-4 py-2.5 text-xs outline-none focus:ring-4 focus:ring-cyan-100"
                >

                <div class="flex size-9 items-center justify-center rounded-full bg-cyan-100 text-xs font-bold text-cyan-700">
                    AB
                </div>
            </div>
            """,
            Code = """
            <header class="flex items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="text-sm font-extrabold text-slate-950">
                    Workspace
                </div>

                <input
                    type="search"
                    placeholder="Search..."
                    class="min-w-0 flex-1 rounded-xl bg-slate-100 px-4 py-2.5 text-xs outline-none focus:ring-4 focus:ring-cyan-100"
                >

                <div class="flex size-9 items-center justify-center rounded-full bg-cyan-100 text-xs font-bold text-cyan-700">
                    AB
                </div>
            </header>
            """
        },

        new Recipe
        {
            Id = 193,
            Name = "Breadcrumb Header",
            Category = "Headers",
            Description = "Page title combined with breadcrumb navigation.",
            Accent = "emerald",
            Preview = """
            <div class="w-full">
                <div class="flex items-center gap-2 text-[10px] font-bold uppercase tracking-wider text-slate-400">
                    <span>Projects</span>
                    <span>/</span>
                    <span class="text-emerald-600">Settings</span>
                </div>

                <div class="mt-3 text-3xl font-extrabold tracking-tight text-slate-950">
                    Project settings
                </div>
            </div>
            """,
            Code = """
            <header>
                <nav class="flex items-center gap-2 text-[10px] font-bold uppercase tracking-wider text-slate-400">
                    <a href="#">Projects</a>
                    <span>/</span>
                    <span class="text-emerald-600">Settings</span>
                </nav>

                <h1 class="mt-3 text-3xl font-extrabold tracking-tight text-slate-950">
                    Project settings
                </h1>
            </header>
            """
        },

        new Recipe
        {
            Id = 194,
            Name = "Dark App Header",
            Category = "Headers",
            Description = "Dark application header with status and user profile.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-center justify-between rounded-2xl bg-slate-950 p-4">
                <div>
                    <div class="text-sm font-bold text-white">
                        Control Center
                    </div>
                    <div class="mt-1 text-[10px] text-cyan-400">
                        SYSTEM ONLINE
                    </div>
                </div>

                <div class="flex items-center gap-3">
                    <span class="size-2 rounded-full bg-emerald-400 shadow-[0_0_12px_rgba(52,211,153,0.8)]"></span>

                    <div class="flex size-9 items-center justify-center rounded-full bg-white/10 text-xs font-bold text-white">
                        AB
                    </div>
                </div>
            </div>
            """,
            Code = """
            <header class="flex items-center justify-between rounded-2xl bg-slate-950 p-4">
                <div>
                    <div class="text-sm font-bold text-white">
                        Control Center
                    </div>

                    <div class="mt-1 text-[10px] text-cyan-400">
                        SYSTEM ONLINE
                    </div>
                </div>

                <div class="flex items-center gap-3">
                    <span class="size-2 rounded-full bg-emerald-400 shadow-[0_0_12px_rgba(52,211,153,0.8)]"></span>

                    <div class="flex size-9 items-center justify-center rounded-full bg-white/10 text-xs font-bold text-white">
                        AB
                    </div>
                </div>
            </header>
            """
        },

        new Recipe
        {
            Id = 195,
            Name = "Action Header",
            Category = "Headers",
            Description = "Page header with secondary and primary action buttons.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-end justify-between gap-5">
                <div>
                    <div class="text-xs font-bold uppercase tracking-widest text-cyan-600">
                        Projects
                    </div>

                    <div class="mt-2 text-2xl font-extrabold text-slate-950">
                        Design System
                    </div>
                </div>

                <div class="flex gap-2">
                    <button class="rounded-xl border border-slate-200 bg-white px-4 py-2.5 text-xs font-bold text-slate-600">
                        Preview
                    </button>

                    <button class="rounded-xl bg-slate-950 px-4 py-2.5 text-xs font-bold text-white">
                        Publish
                    </button>
                </div>
            </div>
            """,
            Code = """
            <header class="flex items-end justify-between gap-5">
                <div>
                    <div class="text-xs font-bold uppercase tracking-widest text-cyan-600">
                        Projects
                    </div>

                    <h1 class="mt-2 text-2xl font-extrabold text-slate-950">
                        Design System
                    </h1>
                </div>

                <div class="flex gap-2">
                    <button class="rounded-xl border border-slate-200 bg-white px-4 py-2.5 text-xs font-bold text-slate-600">
                        Preview
                    </button>

                    <button class="rounded-xl bg-slate-950 px-4 py-2.5 text-xs font-bold text-white">
                        Publish
                    </button>
                </div>
            </header>
            """
        }
    ];
}