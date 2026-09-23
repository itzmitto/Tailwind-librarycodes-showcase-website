public static class ShowcaseRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 76,
            Name = "Clean Data Table",
            Category = "Tables",
            Description = "Reusable clean table for dashboards and admin panels.",
            Accent = "cyan",
            Preview = """
            <div class="w-full overflow-hidden rounded-2xl border border-slate-200 bg-white">
                <div class="grid grid-cols-3 border-b border-slate-200 bg-slate-50 px-4 py-3 text-xs font-bold text-slate-500">
                    <span>Name</span>
                    <span>Status</span>
                    <span>Role</span>
                </div>
                <div class="grid grid-cols-3 px-4 py-4 text-sm">
                    <span class="font-semibold text-slate-900">Andre</span>
                    <span class="text-emerald-600">Active</span>
                    <span class="text-slate-500">Developer</span>
                </div>
            </div>
            """,
            Code = """
            <div class="overflow-hidden rounded-2xl border border-slate-200 bg-white">
                <table class="w-full text-left">
                    <thead class="border-b border-slate-200 bg-slate-50">
                        <tr>
                            <th class="px-5 py-3 text-xs font-bold text-slate-500">
                                Name
                            </th>
                            <th class="px-5 py-3 text-xs font-bold text-slate-500">
                                Status
                            </th>
                            <th class="px-5 py-3 text-xs font-bold text-slate-500">
                                Role
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class="border-b border-slate-100 last:border-0">
                            <td class="px-5 py-4 text-sm font-semibold text-slate-900">
                                Andre
                            </td>
                            <td class="px-5 py-4 text-sm text-emerald-600">
                                Active
                            </td>
                            <td class="px-5 py-4 text-sm text-slate-500">
                                Developer
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            """
        },

        new Recipe
        {
            Id = 77,
            Name = "Breadcrumbs",
            Category = "Breadcrumbs",
            Description = "Compact breadcrumb trail for nested pages.",
            Accent = "cyan",
            Preview = """
            <nav class="flex items-center gap-2 text-sm">
                <a class="font-semibold text-slate-400">Projects</a>
                <span class="text-slate-300">/</span>
                <a class="font-semibold text-slate-400">Website</a>
                <span class="text-slate-300">/</span>
                <span class="font-bold text-cyan-600">Settings</span>
            </nav>
            """,
            Code = """
            <nav class="flex items-center gap-2 text-sm">
                <a href="#" class="font-semibold text-slate-400 hover:text-slate-700">
                    Projects
                </a>
                <span class="text-slate-300">/</span>
                <a href="#" class="font-semibold text-slate-400 hover:text-slate-700">
                    Website
                </a>
                <span class="text-slate-300">/</span>
                <span class="font-bold text-cyan-600">
                    Settings
                </span>
            </nav>
            """
        },

        new Recipe
        {
            Id = 78,
            Name = "Command Palette",
            Category = "Command Palette",
            Description = "Search command surface for fast keyboard-driven actions.",
            Accent = "cyan",
            Preview = """
            <div class="w-full max-w-md overflow-hidden rounded-2xl border border-slate-200 bg-white shadow-xl shadow-slate-200/70">
                <div class="border-b border-slate-200 p-3">
                    <input
                        type="text"
                        placeholder="Search commands..."
                        class="w-full bg-transparent px-2 py-2 text-sm outline-none"
                    >
                </div>
                <div class="p-2">
                    <div class="rounded-xl bg-cyan-50 px-3 py-3 text-sm font-semibold text-cyan-800">
                        Create new project
                    </div>
                    <div class="px-3 py-3 text-sm font-semibold text-slate-500">
                        Open settings
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="w-full max-w-md overflow-hidden rounded-2xl border border-slate-200 bg-white shadow-xl shadow-slate-200/70">
                <div class="border-b border-slate-200 p-3">
                    <input
                        type="text"
                        placeholder="Search commands..."
                        class="w-full bg-transparent px-2 py-2 text-sm outline-none"
                    >
                </div>

                <div class="p-2">
                    <button class="w-full rounded-xl bg-cyan-50 px-3 py-3 text-left text-sm font-semibold text-cyan-800">
                        Create new project
                    </button>

                    <button class="w-full rounded-xl px-3 py-3 text-left text-sm font-semibold text-slate-500 hover:bg-slate-50">
                        Open settings
                    </button>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 79,
            Name = "Pricing Card",
            Category = "Pricing",
            Description = "Clean pricing card with highlighted action.",
            Accent = "emerald",
            Preview = """
            <div class="w-full rounded-3xl border border-emerald-200 bg-white p-6 shadow-lg shadow-emerald-100/50">
                <div class="text-xs font-bold uppercase tracking-widest text-emerald-600">
                    Pro
                </div>
                <div class="mt-4 text-4xl font-extrabold tracking-tight text-slate-950">
                    €19
                </div>
                <div class="mt-1 text-sm text-slate-400">
                    per month
                </div>
                <button class="mt-6 w-full rounded-xl bg-emerald-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Upgrade
                </button>
            </div>
            """,
            Code = """
            <div class="rounded-3xl border border-emerald-200 bg-white p-6 shadow-lg shadow-emerald-100/50">
                <div class="text-xs font-bold uppercase tracking-widest text-emerald-600">
                    Pro
                </div>

                <div class="mt-4 text-4xl font-extrabold tracking-tight text-slate-950">
                    €19
                </div>

                <div class="mt-1 text-sm text-slate-400">
                    per month
                </div>

                <button class="mt-6 w-full rounded-xl bg-emerald-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Upgrade
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 80,
            Name = "Vertical Timeline",
            Category = "Timeline",
            Description = "Reusable vertical project timeline.",
            Accent = "cyan",
            Preview = """
            <div class="w-full space-y-5">
                <div class="flex gap-4">
                    <div class="flex flex-col items-center">
                        <div class="size-3 rounded-full bg-cyan-400"></div>
                        <div class="mt-1 h-full w-px bg-slate-200"></div>
                    </div>
                    <div>
                        <div class="text-sm font-bold text-slate-900">Project created</div>
                        <div class="mt-1 text-xs text-slate-400">09:20</div>
                    </div>
                </div>
                <div class="flex gap-4">
                    <div class="size-3 rounded-full bg-emerald-400"></div>
                    <div>
                        <div class="text-sm font-bold text-slate-900">Deployment finished</div>
                        <div class="mt-1 text-xs text-slate-400">10:42</div>
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="space-y-5">
                <div class="flex gap-4">
                    <div class="flex flex-col items-center">
                        <div class="size-3 rounded-full bg-cyan-400"></div>
                        <div class="mt-1 h-full w-px bg-slate-200"></div>
                    </div>

                    <div>
                        <div class="text-sm font-bold text-slate-900">
                            Project created
                        </div>
                        <div class="mt-1 text-xs text-slate-400">
                            09:20
                        </div>
                    </div>
                </div>

                <div class="flex gap-4">
                    <div class="size-3 rounded-full bg-emerald-400"></div>

                    <div>
                        <div class="text-sm font-bold text-slate-900">
                            Deployment finished
                        </div>
                        <div class="mt-1 text-xs text-slate-400">
                            10:42
                        </div>
                    </div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 81,
            Name = "Horizontal Stepper",
            Category = "Steppers",
            Description = "Multi-step progress navigation for forms.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full items-center">
                <div class="flex size-9 items-center justify-center rounded-full bg-emerald-400 text-sm font-bold">1</div>
                <div class="h-1 flex-1 bg-emerald-400"></div>
                <div class="flex size-9 items-center justify-center rounded-full bg-emerald-400 text-sm font-bold">2</div>
                <div class="h-1 flex-1 bg-slate-200"></div>
                <div class="flex size-9 items-center justify-center rounded-full bg-slate-200 text-sm font-bold text-slate-500">3</div>
            </div>
            """,
            Code = """
            <div class="flex items-center">
                <div class="flex size-9 items-center justify-center rounded-full bg-emerald-400 text-sm font-bold">
                    1
                </div>

                <div class="h-1 flex-1 bg-emerald-400"></div>

                <div class="flex size-9 items-center justify-center rounded-full bg-emerald-400 text-sm font-bold">
                    2
                </div>

                <div class="h-1 flex-1 bg-slate-200"></div>

                <div class="flex size-9 items-center justify-center rounded-full bg-slate-200 text-sm font-bold text-slate-500">
                    3
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 82,
            Name = "Code Block",
            Category = "Code Blocks",
            Description = "Reusable dark code surface with filename header.",
            Accent = "cyan",
            Preview = """
            <div class="w-full overflow-hidden rounded-2xl bg-slate-950">
                <div class="border-b border-white/10 px-4 py-3 font-mono text-[10px] text-slate-400">
                    app.js
                </div>
                <pre class="overflow-x-auto p-4 font-mono text-xs leading-6 text-slate-200">const hello = "world";</pre>
            </div>
            """,
            Code = """
            <div class="overflow-hidden rounded-2xl bg-slate-950">
                <div class="border-b border-white/10 px-4 py-3 font-mono text-[10px] text-slate-400">
                    app.js
                </div>

                <pre class="overflow-x-auto p-4 font-mono text-xs leading-6 text-slate-200"><code>const hello = "world";</code></pre>
            </div>
            """
        },

        new Recipe
        {
            Id = 83,
            Name = "Notification Panel",
            Category = "Notifications",
            Description = "Stacked notification panel for dashboards.",
            Accent = "cyan",
            Preview = """
            <div class="w-full overflow-hidden rounded-2xl border border-slate-200 bg-white">
                <div class="border-b border-slate-200 px-5 py-4 font-bold text-slate-900">
                    Notifications
                </div>
                <div class="border-b border-slate-100 px-5 py-4">
                    <div class="text-sm font-semibold text-slate-900">Build completed</div>
                    <div class="mt-1 text-xs text-slate-400">2 minutes ago</div>
                </div>
                <div class="px-5 py-4">
                    <div class="text-sm font-semibold text-slate-900">New comment</div>
                    <div class="mt-1 text-xs text-slate-400">14 minutes ago</div>
                </div>
            </div>
            """,
            Code = """
            <div class="overflow-hidden rounded-2xl border border-slate-200 bg-white">
                <div class="border-b border-slate-200 px-5 py-4 font-bold text-slate-900">
                    Notifications
                </div>

                <div class="border-b border-slate-100 px-5 py-4">
                    <div class="text-sm font-semibold text-slate-900">
                        Build completed
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        2 minutes ago
                    </div>
                </div>

                <div class="px-5 py-4">
                    <div class="text-sm font-semibold text-slate-900">
                        New comment
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        14 minutes ago
                    </div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 84,
            Name = "User Menu",
            Category = "Menus",
            Description = "Compact account menu with profile information.",
            Accent = "emerald",
            Preview = """
            <div class="w-64 rounded-2xl border border-slate-200 bg-white p-2 shadow-xl shadow-slate-200/70">
                <div class="border-b border-slate-100 p-3">
                    <div class="text-sm font-bold text-slate-900">Andre</div>
                    <div class="mt-1 text-xs text-slate-400">developer@example.com</div>
                </div>
                <button class="mt-2 w-full rounded-lg px-3 py-2 text-left text-sm font-semibold text-slate-600 hover:bg-slate-100">
                    Settings
                </button>
                <button class="w-full rounded-lg px-3 py-2 text-left text-sm font-semibold text-rose-600 hover:bg-rose-50">
                    Sign out
                </button>
            </div>
            """,
            Code = """
            <div class="w-64 rounded-2xl border border-slate-200 bg-white p-2 shadow-xl shadow-slate-200/70">
                <div class="border-b border-slate-100 p-3">
                    <div class="text-sm font-bold text-slate-900">
                        Andre
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        developer@example.com
                    </div>
                </div>

                <button class="mt-2 w-full rounded-lg px-3 py-2 text-left text-sm font-semibold text-slate-600 hover:bg-slate-100">
                    Settings
                </button>

                <button class="w-full rounded-lg px-3 py-2 text-left text-sm font-semibold text-rose-600 hover:bg-rose-50">
                    Sign out
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 85,
            Name = "Keyboard Shortcut",
            Category = "Utilities",
            Description = "Keyboard shortcut hint for commands and actions.",
            Accent = "cyan",
            Preview = """
            <div class="flex items-center gap-2">
                <span class="text-sm font-semibold text-slate-600">Search</span>
                <kbd class="rounded-lg border border-slate-300 bg-slate-100 px-2 py-1 font-mono text-xs font-bold text-slate-600 shadow-sm">
                    Ctrl
                </kbd>
                <span class="text-slate-300">+</span>
                <kbd class="rounded-lg border border-slate-300 bg-slate-100 px-2 py-1 font-mono text-xs font-bold text-slate-600 shadow-sm">
                    K
                </kbd>
            </div>
            """,
            Code = """
            <div class="flex items-center gap-2">
                <span class="text-sm font-semibold text-slate-600">
                    Search
                </span>

                <kbd class="rounded-lg border border-slate-300 bg-slate-100 px-2 py-1 font-mono text-xs font-bold text-slate-600 shadow-sm">
                    Ctrl
                </kbd>

                <span class="text-slate-300">+</span>

                <kbd class="rounded-lg border border-slate-300 bg-slate-100 px-2 py-1 font-mono text-xs font-bold text-slate-600 shadow-sm">
                    K
                </kbd>
            </div>
            """
        },

        new Recipe
        {
            Id = 86,
            Name = "Data Row",
            Category = "Data",
            Description = "Reusable key and value row for settings and details.",
            Accent = "emerald",
            Preview = """
            <div class="w-full divide-y divide-slate-100 rounded-2xl border border-slate-200 bg-white">
                <div class="flex items-center justify-between px-5 py-4">
                    <span class="text-sm font-semibold text-slate-500">Environment</span>
                    <span class="text-sm font-bold text-slate-900">Production</span>
                </div>
                <div class="flex items-center justify-between px-5 py-4">
                    <span class="text-sm font-semibold text-slate-500">Status</span>
                    <span class="text-sm font-bold text-emerald-600">Online</span>
                </div>
            </div>
            """,
            Code = """
            <div class="divide-y divide-slate-100 rounded-2xl border border-slate-200 bg-white">
                <div class="flex items-center justify-between px-5 py-4">
                    <span class="text-sm font-semibold text-slate-500">
                        Environment
                    </span>
                    <span class="text-sm font-bold text-slate-900">
                        Production
                    </span>
                </div>

                <div class="flex items-center justify-between px-5 py-4">
                    <span class="text-sm font-semibold text-slate-500">
                        Status
                    </span>
                    <span class="text-sm font-bold text-emerald-600">
                        Online
                    </span>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 87,
            Name = "Metric Row",
            Category = "Data",
            Description = "Compact metric row for dashboards and analytics.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-center justify-between rounded-2xl border border-slate-200 bg-white p-5">
                <div>
                    <div class="text-sm font-semibold text-slate-500">Conversion</div>
                    <div class="mt-1 text-2xl font-extrabold text-slate-950">12.8%</div>
                </div>
                <span class="rounded-full bg-emerald-100 px-3 py-1 text-xs font-bold text-emerald-700">
                    +4.2%
                </span>
            </div>
            """,
            Code = """
            <div class="flex items-center justify-between rounded-2xl border border-slate-200 bg-white p-5">
                <div>
                    <div class="text-sm font-semibold text-slate-500">
                        Conversion
                    </div>
                    <div class="mt-1 text-2xl font-extrabold text-slate-950">
                        12.8%
                    </div>
                </div>

                <span class="rounded-full bg-emerald-100 px-3 py-1 text-xs font-bold text-emerald-700">
                    +4.2%
                </span>
            </div>
            """
        }
    ];
}