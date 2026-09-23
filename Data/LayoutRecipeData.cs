public static class LayoutRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 40,
            Name = "Centered Container",
            Category = "Layouts",
            Description = "Reusable centered page container with responsive spacing.",
            Accent = "cyan",
            Preview = """
            <div class="mx-auto w-full max-w-3xl rounded-2xl border border-dashed border-cyan-300 bg-cyan-50 px-6 py-10 text-center">
                <span class="text-sm font-bold text-cyan-700">
                    max-w-3xl
                </span>
            </div>
            """,
            Code = """
            <div class="mx-auto w-full max-w-7xl px-6 lg:px-8">
                Content
            </div>
            """
        },

        new Recipe
        {
            Id = 41,
            Name = "Two Column Split",
            Category = "Layouts",
            Description = "Responsive two-column layout for content and side panels.",
            Accent = "emerald",
            Preview = """
            <div class="grid w-full grid-cols-3 gap-3">
                <div class="col-span-2 h-32 rounded-2xl bg-cyan-100"></div>
                <div class="h-32 rounded-2xl bg-emerald-100"></div>
            </div>
            """,
            Code = """
            <div class="grid grid-cols-1 gap-8 lg:grid-cols-[minmax(0,1fr)_320px]">
                <main>
                    Main content
                </main>
                <aside>
                    Sidebar
                </aside>
            </div>
            """
        },

        new Recipe
        {
            Id = 42,
            Name = "Dashboard Grid",
            Category = "Layouts",
            Description = "Responsive dashboard grid for cards and panels.",
            Accent = "cyan",
            Preview = """
            <div class="grid w-full grid-cols-4 gap-3">
                <div class="col-span-2 h-20 rounded-xl bg-cyan-100"></div>
                <div class="h-20 rounded-xl bg-emerald-100"></div>
                <div class="h-20 rounded-xl bg-slate-200"></div>
                <div class="h-28 rounded-xl bg-slate-100"></div>
                <div class="col-span-3 h-28 rounded-xl bg-cyan-50"></div>
            </div>
            """,
            Code = """
            <div class="grid grid-cols-1 gap-5 md:grid-cols-2 xl:grid-cols-4">
                <div class="md:col-span-2">Large panel</div>
                <div>Panel</div>
                <div>Panel</div>
                <div>Panel</div>
                <div class="md:col-span-2 xl:col-span-3">Wide panel</div>
            </div>
            """
        },

        new Recipe
        {
            Id = 43,
            Name = "Sticky Side Panel",
            Category = "Layouts",
            Description = "Sticky sidebar pattern for settings and detail pages.",
            Accent = "emerald",
            Preview = """
            <div class="grid w-full grid-cols-[1fr_140px] gap-4">
                <div class="space-y-2">
                    <div class="h-10 rounded-xl bg-slate-100"></div>
                    <div class="h-10 rounded-xl bg-slate-100"></div>
                    <div class="h-10 rounded-xl bg-slate-100"></div>
                </div>
                <div class="h-28 rounded-xl border border-emerald-200 bg-emerald-50 p-3 text-xs font-bold text-emerald-700">
                    Sticky
                </div>
            </div>
            """,
            Code = """
            <div class="grid grid-cols-1 gap-8 lg:grid-cols-[1fr_320px]">
                <main>
                    Content
                </main>
                <aside class="self-start lg:sticky lg:top-6">
                    Sticky panel
                </aside>
            </div>
            """
        },

        new Recipe
        {
            Id = 44,
            Name = "Aspect Ratio",
            Category = "Layouts",
            Description = "Responsive media wrapper with 16 by 9 ratio.",
            Accent = "cyan",
            Preview = """
            <div class="aspect-video w-full rounded-2xl bg-gradient-to-br from-cyan-100 to-emerald-100"></div>
            """,
            Code = """
            <div class="aspect-video overflow-hidden rounded-2xl">
                <img
                    src="/image.jpg"
                    alt=""
                    class="h-full w-full object-cover"
                >
            </div>
            """
        },

        new Recipe
        {
            Id = 45,
            Name = "Stat Block",
            Category = "Stats",
            Description = "Reusable statistic block for dashboards.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-6">
                <div class="text-sm font-semibold text-slate-500">
                    Total projects
                </div>
                <div class="mt-3 text-4xl font-extrabold tracking-[-0.05em] text-slate-950">
                    128
                </div>
                <div class="mt-3 text-xs font-bold text-emerald-600">
                    +12.4% this month
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="text-sm font-semibold text-slate-500">
                    Total projects
                </div>
                <div class="mt-3 text-4xl font-extrabold tracking-[-0.05em] text-slate-950">
                    128
                </div>
                <div class="mt-3 text-xs font-bold text-emerald-600">
                    +12.4% this month
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 46,
            Name = "Stat Row",
            Category = "Stats",
            Description = "Horizontal stat layout for compact dashboards.",
            Accent = "emerald",
            Preview = """
            <div class="grid w-full grid-cols-3 divide-x divide-slate-200 rounded-2xl border border-slate-200 bg-white">
                <div class="p-4 text-center">
                    <div class="text-xl font-extrabold">24</div>
                    <div class="mt-1 text-xs text-slate-400">Projects</div>
                </div>
                <div class="p-4 text-center">
                    <div class="text-xl font-extrabold">12</div>
                    <div class="mt-1 text-xs text-slate-400">Active</div>
                </div>
                <div class="p-4 text-center">
                    <div class="text-xl font-extrabold">98%</div>
                    <div class="mt-1 text-xs text-slate-400">Uptime</div>
                </div>
            </div>
            """,
            Code = """
            <div class="grid grid-cols-3 divide-x divide-slate-200 rounded-2xl border border-slate-200 bg-white">
                <div class="p-5 text-center">
                    <div class="text-2xl font-extrabold">24</div>
                    <div class="mt-1 text-xs text-slate-400">Projects</div>
                </div>
                <div class="p-5 text-center">
                    <div class="text-2xl font-extrabold">12</div>
                    <div class="mt-1 text-xs text-slate-400">Active</div>
                </div>
                <div class="p-5 text-center">
                    <div class="text-2xl font-extrabold">98%</div>
                    <div class="mt-1 text-xs text-slate-400">Uptime</div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 47,
            Name = "Avatar Group",
            Category = "Avatars",
            Description = "Overlapping avatar group for teams and collaborators.",
            Accent = "cyan",
            Preview = """
            <div class="flex -space-x-3">
                <div class="flex size-11 items-center justify-center rounded-full border-2 border-white bg-cyan-200 text-sm font-bold text-cyan-800">A</div>
                <div class="flex size-11 items-center justify-center rounded-full border-2 border-white bg-emerald-200 text-sm font-bold text-emerald-800">B</div>
                <div class="flex size-11 items-center justify-center rounded-full border-2 border-white bg-violet-200 text-sm font-bold text-violet-800">C</div>
                <div class="flex size-11 items-center justify-center rounded-full border-2 border-white bg-slate-900 text-xs font-bold text-white">+4</div>
            </div>
            """,
            Code = """
            <div class="flex -space-x-3">
                <img class="size-11 rounded-full border-2 border-white object-cover" src="/avatar-1.jpg" alt="">
                <img class="size-11 rounded-full border-2 border-white object-cover" src="/avatar-2.jpg" alt="">
                <img class="size-11 rounded-full border-2 border-white object-cover" src="/avatar-3.jpg" alt="">
                <div class="flex size-11 items-center justify-center rounded-full border-2 border-white bg-slate-900 text-xs font-bold text-white">
                    +4
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 48,
            Name = "Profile Avatar",
            Category = "Avatars",
            Description = "Avatar with status indicator.",
            Accent = "emerald",
            Preview = """
            <div class="relative">
                <div class="flex size-16 items-center justify-center rounded-full bg-cyan-100 text-xl font-extrabold text-cyan-700">
                    AB
                </div>
                <span class="absolute bottom-0 right-0 size-4 rounded-full border-2 border-white bg-emerald-400"></span>
            </div>
            """,
            Code = """
            <div class="relative inline-flex">
                <img
                    src="/avatar.jpg"
                    alt=""
                    class="size-16 rounded-full object-cover"
                >
                <span class="absolute bottom-0 right-0 size-4 rounded-full border-2 border-white bg-emerald-400"></span>
            </div>
            """
        },

        new Recipe
        {
            Id = 49,
            Name = "Empty State",
            Category = "Empty States",
            Description = "Reusable empty state for lists and dashboards.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl border border-dashed border-slate-300 bg-slate-50 p-8 text-center">
                <div class="mx-auto flex size-12 items-center justify-center rounded-xl bg-cyan-100 font-bold text-cyan-700">
                    +
                </div>
                <h3 class="mt-4 font-extrabold text-slate-950">
                    No projects yet
                </h3>
                <p class="mt-2 text-sm text-slate-500">
                    Create your first project to get started.
                </p>
                <button class="mt-5 rounded-xl bg-cyan-400 px-4 py-2.5 text-sm font-bold text-slate-950">
                    Create project
                </button>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-dashed border-slate-300 bg-slate-50 p-8 text-center">
                <div class="mx-auto flex size-12 items-center justify-center rounded-xl bg-cyan-100 font-bold text-cyan-700">
                    +
                </div>
                <h3 class="mt-4 font-extrabold text-slate-950">
                    No projects yet
                </h3>
                <p class="mt-2 text-sm text-slate-500">
                    Create your first project to get started.
                </p>
                <button class="mt-5 rounded-xl bg-cyan-400 px-4 py-2.5 text-sm font-bold text-slate-950">
                    Create project
                </button>
            </div>
            """
        }
    ];
}