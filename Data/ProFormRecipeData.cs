public static class ProFormRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 151,
            Name = "Form Section",
            Category = "Forms Pro",
            Description = "Professional settings section with aligned labels and fields.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-6">
                <div class="mb-6">
                    <div class="font-extrabold text-slate-950">
                        Project details
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        Basic information about your project.
                    </div>
                </div>

                <div class="space-y-4">
                    <input
                        type="text"
                        placeholder="Project name"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                    >

                    <input
                        type="text"
                        placeholder="Project URL"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                    >
                </div>
            </div>
            """,
            Code = """
            <section class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="mb-6">
                    <div class="font-extrabold text-slate-950">
                        Project details
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        Basic information about your project.
                    </div>
                </div>

                <div class="space-y-4">
                    <input
                        type="text"
                        placeholder="Project name"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                    >

                    <input
                        type="text"
                        placeholder="Project URL"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                    >
                </div>
            </section>
            """
        },

        new Recipe
        {
            Id = 152,
            Name = "Input With Counter",
            Category = "Forms Pro",
            Description = "Text input with maximum character counter.",
            Accent = "cyan",
            Preview = """
            <div class="w-full">
                <div class="mb-2 flex justify-between">
                    <label class="text-sm font-bold text-slate-700">
                        Project title
                    </label>

                    <span class="text-xs text-slate-400">
                        18 / 60
                    </span>
                </div>

                <input
                    type="text"
                    value="Tailwind Recipe Lab"
                    class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
            </div>
            """,
            Code = """
            <div>
                <div class="mb-2 flex justify-between">
                    <label class="text-sm font-bold text-slate-700">
                        Project title
                    </label>

                    <span class="text-xs text-slate-400">
                        18 / 60
                    </span>
                </div>

                <input
                    type="text"
                    class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
            </div>
            """
        },

        new Recipe
        {
            Id = 153,
            Name = "Password Strength",
            Category = "Forms Pro",
            Description = "Password input with visual strength indicator.",
            Accent = "emerald",
            Preview = """
            <div class="w-full">
                <input
                    type="password"
                    value="supersecure"
                    class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                >

                <div class="mt-3 grid grid-cols-4 gap-1.5">
                    <div class="h-1 rounded-full bg-emerald-400"></div>
                    <div class="h-1 rounded-full bg-emerald-400"></div>
                    <div class="h-1 rounded-full bg-emerald-400"></div>
                    <div class="h-1 rounded-full bg-slate-200"></div>
                </div>

                <div class="mt-2 text-xs font-bold text-emerald-600">
                    Strong password
                </div>
            </div>
            """,
            Code = """
            <div>
                <input
                    type="password"
                    class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                >

                <div class="mt-3 grid grid-cols-4 gap-1.5">
                    <div class="h-1 rounded-full bg-emerald-400"></div>
                    <div class="h-1 rounded-full bg-emerald-400"></div>
                    <div class="h-1 rounded-full bg-emerald-400"></div>
                    <div class="h-1 rounded-full bg-slate-200"></div>
                </div>

                <div class="mt-2 text-xs font-bold text-emerald-600">
                    Strong password
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 154,
            Name = "Tag Input",
            Category = "Forms Pro",
            Description = "Tag-style input for skills, categories or keywords.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full flex-wrap items-center gap-2 rounded-xl border border-slate-300 bg-white p-2.5">
                <span class="rounded-lg bg-cyan-100 px-3 py-1.5 text-xs font-bold text-cyan-700">
                    React ×
                </span>

                <span class="rounded-lg bg-emerald-100 px-3 py-1.5 text-xs font-bold text-emerald-700">
                    Tailwind ×
                </span>

                <input
                    type="text"
                    placeholder="Add tag..."
                    class="min-w-24 flex-1 bg-transparent px-2 text-sm outline-none"
                >
            </div>
            """,
            Code = """
            <div class="flex flex-wrap items-center gap-2 rounded-xl border border-slate-300 bg-white p-2.5">
                <span class="rounded-lg bg-cyan-100 px-3 py-1.5 text-xs font-bold text-cyan-700">
                    React ×
                </span>

                <span class="rounded-lg bg-emerald-100 px-3 py-1.5 text-xs font-bold text-emerald-700">
                    Tailwind ×
                </span>

                <input
                    type="text"
                    placeholder="Add tag..."
                    class="min-w-24 flex-1 bg-transparent px-2 text-sm outline-none"
                >
            </div>
            """
        },

        new Recipe
        {
            Id = 155,
            Name = "Settings Toggle Row",
            Category = "Forms Pro",
            Description = "Professional settings row with toggle and explanation.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full items-center justify-between gap-6 rounded-2xl border border-slate-200 bg-white p-5">
                <div>
                    <div class="text-sm font-extrabold text-slate-950">
                        Public profile
                    </div>

                    <div class="mt-1 text-xs leading-5 text-slate-400">
                        Allow other users to view your profile.
                    </div>
                </div>

                <label class="cursor-pointer">
                    <input type="checkbox" checked class="peer sr-only">

                    <span class="relative block h-6 w-11 rounded-full bg-slate-300 transition peer-checked:bg-emerald-400 after:absolute after:left-1 after:top-1 after:size-4 after:rounded-full after:bg-white after:transition after:content-[''] peer-checked:after:translate-x-5"></span>
                </label>
            </div>
            """,
            Code = """
            <div class="flex items-center justify-between gap-6 rounded-2xl border border-slate-200 bg-white p-5">
                <div>
                    <div class="text-sm font-extrabold text-slate-950">
                        Public profile
                    </div>

                    <div class="mt-1 text-xs leading-5 text-slate-400">
                        Allow other users to view your profile.
                    </div>
                </div>

                <label class="cursor-pointer">
                    <input type="checkbox" class="peer sr-only">

                    <span class="relative block h-6 w-11 rounded-full bg-slate-300 transition peer-checked:bg-emerald-400 after:absolute after:left-1 after:top-1 after:size-4 after:rounded-full after:bg-white after:transition after:content-[''] peer-checked:after:translate-x-5"></span>
                </label>
            </div>
            """
        }
    ];
}