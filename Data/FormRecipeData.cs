public static class FormRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 50,
            Name = "Login Form",
            Category = "Forms",
            Description = "Clean login form with reusable Tailwind styling.",
            Accent = "cyan",
            Preview = """
            <div class="w-full max-w-sm space-y-4">
                <input
                    type="email"
                    placeholder="Email"
                    class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
                <input
                    type="password"
                    placeholder="Password"
                    class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
                <button class="w-full rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950 hover:bg-cyan-300">
                    Sign in
                </button>
            </div>
            """,
            Code = """
            <form class="space-y-4">
                <input
                    type="email"
                    placeholder="Email"
                    class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
                <input
                    type="password"
                    placeholder="Password"
                    class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
                <button class="w-full rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950 hover:bg-cyan-300">
                    Sign in
                </button>
            </form>
            """
        },

        new Recipe
        {
            Id = 51,
            Name = "Form Field",
            Category = "Forms",
            Description = "Reusable labeled input with helper text.",
            Accent = "cyan",
            Preview = """
            <label class="block w-full">
                <span class="text-sm font-bold text-slate-700">
                    Project name
                </span>
                <input
                    type="text"
                    placeholder="My project"
                    class="mt-2 w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none transition focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
                <span class="mt-2 block text-xs text-slate-400">
                    You can change this later.
                </span>
            </label>
            """,
            Code = """
            <label class="block">
                <span class="text-sm font-bold text-slate-700">
                    Project name
                </span>
                <input
                    type="text"
                    placeholder="My project"
                    class="mt-2 w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none transition focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
                <span class="mt-2 block text-xs text-slate-400">
                    You can change this later.
                </span>
            </label>
            """
        },

        new Recipe
        {
            Id = 52,
            Name = "Textarea",
            Category = "Forms",
            Description = "Clean textarea with focus styling.",
            Accent = "emerald",
            Preview = """
            <textarea
                rows="4"
                placeholder="Write a description..."
                class="w-full resize-none rounded-xl border border-slate-300 bg-white px-4 py-3 text-sm outline-none transition focus:border-emerald-400 focus:ring-4 focus:ring-emerald-100"
            ></textarea>
            """,
            Code = """
            <textarea
                rows="4"
                placeholder="Write a description..."
                class="w-full resize-none rounded-xl border border-slate-300 bg-white px-4 py-3 text-sm outline-none transition focus:border-emerald-400 focus:ring-4 focus:ring-emerald-100"
            ></textarea>
            """
        },

        new Recipe
        {
            Id = 53,
            Name = "Inline Form",
            Category = "Forms",
            Description = "Compact horizontal form for email and search actions.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full gap-2">
                <input
                    type="email"
                    placeholder="Email address"
                    class="min-w-0 flex-1 rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
                <button class="rounded-xl bg-cyan-400 px-5 text-sm font-bold text-slate-950 hover:bg-cyan-300">
                    Join
                </button>
            </div>
            """,
            Code = """
            <form class="flex gap-2">
                <input
                    type="email"
                    placeholder="Email address"
                    class="min-w-0 flex-1 rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
                <button class="rounded-xl bg-cyan-400 px-5 text-sm font-bold text-slate-950 hover:bg-cyan-300">
                    Join
                </button>
            </form>
            """
        },

        new Recipe
        {
            Id = 54,
            Name = "File Dropzone",
            Category = "Forms",
            Description = "Dashed upload dropzone for files and images.",
            Accent = "cyan",
            Preview = """
            <label class="block w-full cursor-pointer rounded-2xl border-2 border-dashed border-slate-300 bg-slate-50 p-8 text-center transition hover:border-cyan-400 hover:bg-cyan-50">
                <div class="text-sm font-bold text-slate-700">
                    Drop files here
                </div>
                <div class="mt-2 text-xs text-slate-400">
                    or click to browse
                </div>
                <input type="file" class="hidden">
            </label>
            """,
            Code = """
            <label class="block cursor-pointer rounded-2xl border-2 border-dashed border-slate-300 bg-slate-50 p-8 text-center transition hover:border-cyan-400 hover:bg-cyan-50">
                <div class="text-sm font-bold text-slate-700">
                    Drop files here
                </div>
                <div class="mt-2 text-xs text-slate-400">
                    or click to browse
                </div>
                <input type="file" class="hidden">
            </label>
            """
        },

        new Recipe
        {
            Id = 55,
            Name = "Floating Label",
            Category = "Inputs",
            Description = "Input with floating label using Tailwind peer utilities.",
            Accent = "cyan",
            Preview = """
            <div class="relative w-full">
                <input
                    id="floating-email"
                    type="email"
                    placeholder=" "
                    class="peer w-full rounded-xl border border-slate-300 bg-white px-4 pb-2 pt-6 text-sm outline-none transition focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
                <label
                    for="floating-email"
                    class="pointer-events-none absolute left-4 top-2 text-xs font-semibold text-slate-400 transition peer-placeholder-shown:top-4 peer-placeholder-shown:text-sm peer-focus:top-2 peer-focus:text-xs peer-focus:text-cyan-600"
                >
                    Email address
                </label>
            </div>
            """,
            Code = """
            <div class="relative">
                <input
                    id="email"
                    type="email"
                    placeholder=" "
                    class="peer w-full rounded-xl border border-slate-300 bg-white px-4 pb-2 pt-6 text-sm outline-none transition focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
                <label
                    for="email"
                    class="pointer-events-none absolute left-4 top-2 text-xs font-semibold text-slate-400 transition peer-placeholder-shown:top-4 peer-placeholder-shown:text-sm peer-focus:top-2 peer-focus:text-xs peer-focus:text-cyan-600"
                >
                    Email address
                </label>
            </div>
            """
        },

        new Recipe
        {
            Id = 56,
            Name = "Input Prefix",
            Category = "Inputs",
            Description = "Input field with fixed URL prefix.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full overflow-hidden rounded-xl border border-slate-300 bg-white focus-within:border-emerald-400 focus-within:ring-4 focus-within:ring-emerald-100">
                <span class="flex items-center border-r border-slate-200 bg-slate-50 px-4 text-sm text-slate-400">
                    https://
                </span>
                <input
                    type="text"
                    placeholder="example.com"
                    class="min-w-0 flex-1 px-4 py-3 text-sm outline-none"
                >
            </div>
            """,
            Code = """
            <div class="flex overflow-hidden rounded-xl border border-slate-300 bg-white focus-within:border-emerald-400 focus-within:ring-4 focus-within:ring-emerald-100">
                <span class="flex items-center border-r border-slate-200 bg-slate-50 px-4 text-sm text-slate-400">
                    https://
                </span>
                <input
                    type="text"
                    placeholder="example.com"
                    class="min-w-0 flex-1 px-4 py-3 text-sm outline-none"
                >
            </div>
            """
        },

        new Recipe
        {
            Id = 57,
            Name = "Segment Control",
            Category = "Controls",
            Description = "Compact segmented control for view switching.",
            Accent = "cyan",
            Preview = """
            <div class="inline-grid grid-cols-3 rounded-xl bg-slate-100 p-1">
                <button class="rounded-lg bg-white px-4 py-2 text-xs font-bold text-cyan-600 shadow-sm">
                    Grid
                </button>
                <button class="rounded-lg px-4 py-2 text-xs font-bold text-slate-500">
                    List
                </button>
                <button class="rounded-lg px-4 py-2 text-xs font-bold text-slate-500">
                    Table
                </button>
            </div>
            """,
            Code = """
            <div class="inline-grid grid-cols-3 rounded-xl bg-slate-100 p-1">
                <button class="rounded-lg bg-white px-4 py-2 text-xs font-bold text-cyan-600 shadow-sm">
                    Grid
                </button>
                <button class="rounded-lg px-4 py-2 text-xs font-bold text-slate-500">
                    List
                </button>
                <button class="rounded-lg px-4 py-2 text-xs font-bold text-slate-500">
                    Table
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 58,
            Name = "Switch Row",
            Category = "Controls",
            Description = "Settings row with label, description and switch.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full items-center justify-between gap-6 rounded-2xl border border-slate-200 bg-white p-5">
                <div>
                    <div class="text-sm font-bold text-slate-900">
                        Email notifications
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        Receive project updates.
                    </div>
                </div>
                <label class="cursor-pointer">
                    <input type="checkbox" class="peer sr-only" checked>
                    <span class="relative block h-6 w-11 rounded-full bg-slate-300 transition peer-checked:bg-emerald-400 after:absolute after:left-1 after:top-1 after:size-4 after:rounded-full after:bg-white after:transition after:content-[''] peer-checked:after:translate-x-5"></span>
                </label>
            </div>
            """,
            Code = """
            <div class="flex items-center justify-between gap-6 rounded-2xl border border-slate-200 bg-white p-5">
                <div>
                    <div class="text-sm font-bold text-slate-900">
                        Email notifications
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        Receive project updates.
                    </div>
                </div>
                <label class="cursor-pointer">
                    <input type="checkbox" class="peer sr-only">
                    <span class="relative block h-6 w-11 rounded-full bg-slate-300 transition peer-checked:bg-emerald-400 after:absolute after:left-1 after:top-1 after:size-4 after:rounded-full after:bg-white after:transition after:content-[''] peer-checked:after:translate-x-5"></span>
                </label>
            </div>
            """
        },

        new Recipe
        {
            Id = 59,
            Name = "Checkbox List",
            Category = "Checkboxes",
            Description = "Stacked checkbox group for filters and forms.",
            Accent = "cyan",
            Preview = """
            <div class="grid w-full gap-2">
                <label class="flex cursor-pointer items-center gap-3 rounded-xl border border-slate-200 p-3">
                    <input type="checkbox" checked class="size-4 accent-cyan-400">
                    <span class="text-sm font-semibold text-slate-700">React</span>
                </label>
                <label class="flex cursor-pointer items-center gap-3 rounded-xl border border-slate-200 p-3">
                    <input type="checkbox" class="size-4 accent-cyan-400">
                    <span class="text-sm font-semibold text-slate-700">Vue</span>
                </label>
                <label class="flex cursor-pointer items-center gap-3 rounded-xl border border-slate-200 p-3">
                    <input type="checkbox" class="size-4 accent-cyan-400">
                    <span class="text-sm font-semibold text-slate-700">Astro</span>
                </label>
            </div>
            """,
            Code = """
            <div class="grid gap-2">
                <label class="flex cursor-pointer items-center gap-3 rounded-xl border border-slate-200 p-3">
                    <input type="checkbox" class="size-4 accent-cyan-400">
                    <span class="text-sm font-semibold text-slate-700">React</span>
                </label>
                <label class="flex cursor-pointer items-center gap-3 rounded-xl border border-slate-200 p-3">
                    <input type="checkbox" class="size-4 accent-cyan-400">
                    <span class="text-sm font-semibold text-slate-700">Vue</span>
                </label>
                <label class="flex cursor-pointer items-center gap-3 rounded-xl border border-slate-200 p-3">
                    <input type="checkbox" class="size-4 accent-cyan-400">
                    <span class="text-sm font-semibold text-slate-700">Astro</span>
                </label>
            </div>
            """
        }
    ];
}