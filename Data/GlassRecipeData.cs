public static class GlassRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 96,
            Name = "Frosted Glass Card",
            Category = "Glassmorphism",
            Description = "Classic frosted glass card with backdrop blur.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-3xl bg-gradient-to-br from-cyan-300 via-sky-300 to-emerald-300 p-8">
                <div class="rounded-2xl border border-white/50 bg-white/30 p-6 shadow-xl backdrop-blur-xl">
                    <div class="text-xs font-bold uppercase tracking-widest text-slate-700">
                        Glass
                    </div>
                    <h3 class="mt-8 text-xl font-extrabold text-slate-950">
                        Frosted Surface
                    </h3>
                    <p class="mt-2 text-sm text-slate-700">
                        Transparent layered interface surface.
                    </p>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-white/50 bg-white/30 p-6 shadow-xl backdrop-blur-xl">
                <div class="text-xs font-bold uppercase tracking-widest text-slate-700">
                    Glass
                </div>
                <h3 class="mt-8 text-xl font-extrabold text-slate-950">
                    Frosted Surface
                </h3>
                <p class="mt-2 text-sm text-slate-700">
                    Transparent layered interface surface.
                </p>
            </div>
            """
        },

        new Recipe
        {
            Id = 97,
            Name = "Dark Glass Card",
            Category = "Glassmorphism",
            Description = "Dark translucent glass panel for modern dashboards.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-3xl bg-gradient-to-br from-slate-950 via-cyan-950 to-slate-950 p-8">
                <div class="rounded-2xl border border-white/10 bg-white/5 p-6 shadow-2xl backdrop-blur-2xl">
                    <div class="text-sm font-bold text-cyan-300">
                        Analytics
                    </div>
                    <div class="mt-6 text-4xl font-extrabold text-white">
                        24,820
                    </div>
                    <div class="mt-2 text-xs text-slate-400">
                        Total visitors
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-white/10 bg-white/5 p-6 shadow-2xl backdrop-blur-2xl">
                <div class="text-sm font-bold text-cyan-300">
                    Analytics
                </div>
                <div class="mt-6 text-4xl font-extrabold text-white">
                    24,820
                </div>
                <div class="mt-2 text-xs text-slate-400">
                    Total visitors
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 98,
            Name = "Glass Button",
            Category = "Glassmorphism",
            Description = "Bright glass button for gradient surfaces.",
            Accent = "cyan",
            Preview = """
            <div class="flex justify-center rounded-3xl bg-gradient-to-r from-cyan-400 to-emerald-400 p-10">
                <button class="rounded-xl border border-white/60 bg-white/25 px-6 py-3 text-sm font-bold text-slate-950 shadow-lg backdrop-blur-xl transition hover:bg-white/40">
                    Explore
                </button>
            </div>
            """,
            Code = """
            <button class="rounded-xl border border-white/60 bg-white/25 px-6 py-3 text-sm font-bold text-slate-950 shadow-lg backdrop-blur-xl transition hover:bg-white/40">
                Explore
            </button>
            """
        },

        new Recipe
        {
            Id = 99,
            Name = "Glass Input",
            Category = "Glassmorphism",
            Description = "Transparent glass input with soft focus styling.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-3xl bg-gradient-to-br from-cyan-300 to-violet-300 p-8">
                <input
                    type="text"
                    placeholder="Search..."
                    class="w-full rounded-xl border border-white/50 bg-white/25 px-4 py-3 text-sm text-slate-950 outline-none backdrop-blur-xl placeholder:text-slate-600 focus:bg-white/40 focus:ring-4 focus:ring-white/20"
                >
            </div>
            """,
            Code = """
            <input
                type="text"
                placeholder="Search..."
                class="w-full rounded-xl border border-white/50 bg-white/25 px-4 py-3 text-sm text-slate-950 outline-none backdrop-blur-xl placeholder:text-slate-600 focus:bg-white/40 focus:ring-4 focus:ring-white/20"
            >
            """
        },

        new Recipe
        {
            Id = 100,
            Name = "Glass Profile",
            Category = "Glassmorphism",
            Description = "Glass profile card with layered avatar treatment.",
            Accent = "emerald",
            Preview = """
            <div class="rounded-3xl bg-gradient-to-br from-emerald-300 via-cyan-300 to-sky-300 p-8">
                <div class="rounded-2xl border border-white/50 bg-white/30 p-6 text-center backdrop-blur-2xl">
                    <div class="mx-auto flex size-16 items-center justify-center rounded-full border border-white/70 bg-white/40 text-xl font-extrabold text-slate-900">
                        AB
                    </div>
                    <div class="mt-4 text-lg font-extrabold text-slate-950">
                        Andre
                    </div>
                    <div class="mt-1 text-xs font-semibold text-slate-600">
                        Frontend Developer
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-white/50 bg-white/30 p-6 text-center backdrop-blur-2xl">
                <div class="mx-auto flex size-16 items-center justify-center rounded-full border border-white/70 bg-white/40 text-xl font-extrabold text-slate-900">
                    AB
                </div>
                <div class="mt-4 text-lg font-extrabold text-slate-950">
                    Andre
                </div>
                <div class="mt-1 text-xs font-semibold text-slate-600">
                    Frontend Developer
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 101,
            Name = "Glass Notification",
            Category = "Glassmorphism",
            Description = "Frosted notification panel with bright status icon.",
            Accent = "emerald",
            Preview = """
            <div class="rounded-3xl bg-gradient-to-r from-sky-300 to-emerald-300 p-8">
                <div class="flex items-start gap-4 rounded-2xl border border-white/50 bg-white/30 p-5 backdrop-blur-xl">
                    <div class="flex size-10 items-center justify-center rounded-xl bg-emerald-400/80 font-bold text-slate-950">
                        ✓
                    </div>
                    <div>
                        <div class="text-sm font-extrabold text-slate-950">
                            Upload complete
                        </div>
                        <div class="mt-1 text-xs text-slate-600">
                            Your files are ready.
                        </div>
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="flex items-start gap-4 rounded-2xl border border-white/50 bg-white/30 p-5 backdrop-blur-xl">
                <div class="flex size-10 items-center justify-center rounded-xl bg-emerald-400/80 font-bold text-slate-950">
                    ✓
                </div>
                <div>
                    <div class="text-sm font-extrabold text-slate-950">
                        Upload complete
                    </div>
                    <div class="mt-1 text-xs text-slate-600">
                        Your files are ready.
                    </div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 102,
            Name = "Glass Stat",
            Category = "Glassmorphism",
            Description = "Minimal frosted statistic card.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-3xl bg-gradient-to-br from-cyan-300 to-indigo-300 p-8">
                <div class="rounded-2xl border border-white/40 bg-white/25 p-6 backdrop-blur-xl">
                    <div class="text-xs font-bold uppercase tracking-widest text-slate-600">
                        Revenue
                    </div>
                    <div class="mt-3 text-4xl font-extrabold tracking-tight text-slate-950">
                        €8.4K
                    </div>
                    <div class="mt-2 text-xs font-bold text-emerald-700">
                        +18.2%
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-white/40 bg-white/25 p-6 backdrop-blur-xl">
                <div class="text-xs font-bold uppercase tracking-widest text-slate-600">
                    Revenue
                </div>
                <div class="mt-3 text-4xl font-extrabold tracking-tight text-slate-950">
                    €8.4K
                </div>
                <div class="mt-2 text-xs font-bold text-emerald-700">
                    +18.2%
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 103,
            Name = "Glass Navigation",
            Category = "Glassmorphism",
            Description = "Floating glass navigation strip.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-3xl bg-gradient-to-r from-cyan-300 via-blue-300 to-emerald-300 p-8">
                <div class="flex items-center justify-center gap-1 rounded-2xl border border-white/50 bg-white/25 p-2 backdrop-blur-xl">
                    <button class="rounded-xl bg-white/50 px-4 py-2 text-xs font-bold text-slate-950">
                        Home
                    </button>
                    <button class="rounded-xl px-4 py-2 text-xs font-bold text-slate-700">
                        Projects
                    </button>
                    <button class="rounded-xl px-4 py-2 text-xs font-bold text-slate-700">
                        Settings
                    </button>
                </div>
            </div>
            """,
            Code = """
            <div class="flex items-center gap-1 rounded-2xl border border-white/50 bg-white/25 p-2 backdrop-blur-xl">
                <button class="rounded-xl bg-white/50 px-4 py-2 text-xs font-bold text-slate-950">
                    Home
                </button>
                <button class="rounded-xl px-4 py-2 text-xs font-bold text-slate-700">
                    Projects
                </button>
                <button class="rounded-xl px-4 py-2 text-xs font-bold text-slate-700">
                    Settings
                </button>
            </div>
            """
        }
    ];
}