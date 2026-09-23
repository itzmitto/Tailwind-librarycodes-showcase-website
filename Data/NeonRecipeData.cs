public static class NeonRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 88,
            Name = "Cyan Neon Button",
            Category = "Neon",
            Description = "Dark cyan neon button with a strong glow.",
            Accent = "cyan",
            Preview = """
            <div class="flex justify-center rounded-2xl bg-slate-950 p-10">
                <button class="rounded-xl border border-cyan-400 bg-cyan-400/10 px-6 py-3 text-sm font-bold text-cyan-300 shadow-[0_0_25px_rgba(34,211,238,0.45)] transition hover:bg-cyan-400 hover:text-slate-950 hover:shadow-[0_0_40px_rgba(34,211,238,0.8)]">
                    Launch
                </button>
            </div>
            """,
            Code = """
            <button class="rounded-xl border border-cyan-400 bg-cyan-400/10 px-6 py-3 text-sm font-bold text-cyan-300 shadow-[0_0_25px_rgba(34,211,238,0.45)] transition hover:bg-cyan-400 hover:text-slate-950 hover:shadow-[0_0_40px_rgba(34,211,238,0.8)]">
                Launch
            </button>
            """
        },

        new Recipe
        {
            Id = 89,
            Name = "Emerald Neon Button",
            Category = "Neon",
            Description = "Emerald neon action button for dark interfaces.",
            Accent = "emerald",
            Preview = """
            <div class="flex justify-center rounded-2xl bg-[#06110e] p-10">
                <button class="rounded-xl border border-emerald-400 bg-emerald-400/10 px-6 py-3 text-sm font-bold text-emerald-300 shadow-[0_0_28px_rgba(52,211,153,0.4)] transition hover:bg-emerald-400 hover:text-slate-950">
                    Continue
                </button>
            </div>
            """,
            Code = """
            <button class="rounded-xl border border-emerald-400 bg-emerald-400/10 px-6 py-3 text-sm font-bold text-emerald-300 shadow-[0_0_28px_rgba(52,211,153,0.4)] transition hover:bg-emerald-400 hover:text-slate-950">
                Continue
            </button>
            """
        },

        new Recipe
        {
            Id = 90,
            Name = "Neon Border Card",
            Category = "Neon",
            Description = "Dark card with cyan neon border and ambient glow.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-2xl bg-slate-950 p-6">
                <div class="rounded-2xl border border-cyan-400/70 bg-slate-900 p-6 shadow-[0_0_35px_rgba(34,211,238,0.22)]">
                    <div class="text-xs font-bold uppercase tracking-[0.18em] text-cyan-400">
                        Neon
                    </div>
                    <h3 class="mt-5 text-xl font-extrabold text-white">
                        System Online
                    </h3>
                    <p class="mt-2 text-sm text-slate-400">
                        A glowing card for dark dashboards.
                    </p>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-cyan-400/70 bg-slate-900 p-6 shadow-[0_0_35px_rgba(34,211,238,0.22)]">
                <div class="text-xs font-bold uppercase tracking-[0.18em] text-cyan-400">
                    Neon
                </div>
                <h3 class="mt-5 text-xl font-extrabold text-white">
                    System Online
                </h3>
                <p class="mt-2 text-sm text-slate-400">
                    A glowing card for dark dashboards.
                </p>
            </div>
            """
        },

        new Recipe
        {
            Id = 91,
            Name = "Dual Neon Card",
            Category = "Neon",
            Description = "Card combining cyan and fuchsia neon lighting.",
            Accent = "gradient",
            Preview = """
            <div class="rounded-2xl bg-slate-950 p-6">
                <div class="relative overflow-hidden rounded-2xl border border-white/10 bg-slate-900 p-7">
                    <div class="absolute -left-12 top-0 size-32 rounded-full bg-cyan-400/30 blur-3xl"></div>
                    <div class="absolute -right-12 bottom-0 size-32 rounded-full bg-fuchsia-500/30 blur-3xl"></div>
                    <div class="relative">
                        <div class="text-sm font-bold text-cyan-300">
                            Dual Neon
                        </div>
                        <div class="mt-6 text-3xl font-extrabold text-white">
                            48.2K
                        </div>
                        <div class="mt-2 text-xs text-fuchsia-300">
                            Active sessions
                        </div>
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden rounded-2xl border border-white/10 bg-slate-900 p-7">
                <div class="absolute -left-12 top-0 size-32 rounded-full bg-cyan-400/30 blur-3xl"></div>
                <div class="absolute -right-12 bottom-0 size-32 rounded-full bg-fuchsia-500/30 blur-3xl"></div>

                <div class="relative">
                    <div class="text-sm font-bold text-cyan-300">
                        Dual Neon
                    </div>
                    <div class="mt-6 text-3xl font-extrabold text-white">
                        48.2K
                    </div>
                    <div class="mt-2 text-xs text-fuchsia-300">
                        Active sessions
                    </div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 92,
            Name = "Neon Input",
            Category = "Neon",
            Description = "Dark input field with cyan neon focus state.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-2xl bg-slate-950 p-8">
                <input
                    type="text"
                    placeholder="Search system..."
                    class="w-full rounded-xl border border-cyan-400/40 bg-slate-900 px-4 py-3 text-sm text-white outline-none placeholder:text-slate-500 focus:border-cyan-400 focus:ring-4 focus:ring-cyan-400/10 focus:shadow-[0_0_25px_rgba(34,211,238,0.3)]"
                >
            </div>
            """,
            Code = """
            <input
                type="text"
                placeholder="Search system..."
                class="w-full rounded-xl border border-cyan-400/40 bg-slate-900 px-4 py-3 text-sm text-white outline-none placeholder:text-slate-500 focus:border-cyan-400 focus:ring-4 focus:ring-cyan-400/10 focus:shadow-[0_0_25px_rgba(34,211,238,0.3)]"
            >
            """
        },

        new Recipe
        {
            Id = 93,
            Name = "Neon Badge",
            Category = "Neon",
            Description = "Compact cyan glowing status badge.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-2xl bg-slate-950 p-10 text-center">
                <span class="rounded-full border border-cyan-400/60 bg-cyan-400/10 px-4 py-2 text-xs font-bold uppercase tracking-widest text-cyan-300 shadow-[0_0_20px_rgba(34,211,238,0.35)]">
                    Online
                </span>
            </div>
            """,
            Code = """
            <span class="rounded-full border border-cyan-400/60 bg-cyan-400/10 px-4 py-2 text-xs font-bold uppercase tracking-widest text-cyan-300 shadow-[0_0_20px_rgba(34,211,238,0.35)]">
                Online
            </span>
            """
        },

        new Recipe
        {
            Id = 94,
            Name = "Neon Progress",
            Category = "Neon",
            Description = "Dark progress bar with cyan glowing fill.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl bg-slate-950 p-8">
                <div class="mb-3 flex justify-between text-xs font-bold text-slate-400">
                    <span>Energy</span>
                    <span class="text-cyan-300">78%</span>
                </div>
                <div class="h-2 overflow-hidden rounded-full bg-slate-800">
                    <div class="h-full w-[78%] rounded-full bg-cyan-400 shadow-[0_0_18px_rgba(34,211,238,0.9)]"></div>
                </div>
            </div>
            """,
            Code = """
            <div class="w-full">
                <div class="mb-3 flex justify-between text-xs font-bold text-slate-400">
                    <span>Energy</span>
                    <span class="text-cyan-300">78%</span>
                </div>

                <div class="h-2 overflow-hidden rounded-full bg-slate-800">
                    <div class="h-full w-[78%] rounded-full bg-cyan-400 shadow-[0_0_18px_rgba(34,211,238,0.9)]"></div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 95,
            Name = "Neon Stat",
            Category = "Neon",
            Description = "Glowing statistic display for cyber dashboards.",
            Accent = "emerald",
            Preview = """
            <div class="rounded-2xl bg-slate-950 p-8 text-center">
                <div class="text-xs font-bold uppercase tracking-[0.2em] text-slate-500">
                    Uptime
                </div>
                <div class="mt-4 text-5xl font-extrabold tracking-[-0.06em] text-emerald-300 drop-shadow-[0_0_14px_rgba(52,211,153,0.7)]">
                    99.9%
                </div>
            </div>
            """,
            Code = """
            <div class="text-center">
                <div class="text-xs font-bold uppercase tracking-[0.2em] text-slate-500">
                    Uptime
                </div>
                <div class="mt-4 text-5xl font-extrabold tracking-[-0.06em] text-emerald-300 drop-shadow-[0_0_14px_rgba(52,211,153,0.7)]">
                    99.9%
                </div>
            </div>
            """
        }
    ];
}