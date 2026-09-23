public static class SpecialEffectRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 177,
            Name = "Neon Glass Card",
            Category = "Special Effects",
            Description = "Glassmorphism panel with cyan neon lighting.",
            Accent = "cyan",
            Preview = """
            <div class="relative overflow-hidden rounded-3xl bg-slate-950 p-8">
                <div class="absolute -left-10 top-4 size-36 rounded-full bg-cyan-400/40 blur-3xl"></div>

                <div class="relative rounded-2xl border border-cyan-400/20 bg-white/5 p-6 shadow-[0_0_45px_rgba(34,211,238,0.15)] backdrop-blur-2xl">
                    <div class="text-xs font-bold uppercase tracking-[0.18em] text-cyan-300">
                        Neon Glass
                    </div>

                    <div class="mt-8 text-2xl font-extrabold text-white">
                        Hybrid Surface
                    </div>

                    <p class="mt-2 text-sm text-slate-400">
                        Glass, blur and neon combined.
                    </p>
                </div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden rounded-3xl bg-slate-950 p-8">
                <div class="absolute -left-10 top-4 size-36 rounded-full bg-cyan-400/40 blur-3xl"></div>

                <div class="relative rounded-2xl border border-cyan-400/20 bg-white/5 p-6 shadow-[0_0_45px_rgba(34,211,238,0.15)] backdrop-blur-2xl">
                    Content
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 178,
            Name = "Prism Button",
            Category = "Special Effects",
            Description = "Gradient border button with polished inner surface.",
            Accent = "gradient",
            Preview = """
            <div class="rounded-xl bg-gradient-to-r from-cyan-400 via-violet-500 to-emerald-400 p-[2px]">
                <button class="rounded-[10px] bg-white px-6 py-3 text-sm font-extrabold text-slate-950 transition hover:bg-slate-50">
                    Prism Action
                </button>
            </div>
            """,
            Code = """
            <div class="inline-flex rounded-xl bg-gradient-to-r from-cyan-400 via-violet-500 to-emerald-400 p-[2px]">
                <button class="rounded-[10px] bg-white px-6 py-3 text-sm font-extrabold text-slate-950 transition hover:bg-slate-50">
                    Prism Action
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 179,
            Name = "Glow Divider",
            Category = "Special Effects",
            Description = "Bright cyan separator with ambient glow.",
            Accent = "cyan",
            Preview = """
            <div class="w-full py-8">
                <div class="h-px w-full bg-gradient-to-r from-transparent via-cyan-400 to-transparent shadow-[0_0_14px_rgba(34,211,238,0.8)]"></div>
            </div>
            """,
            Code = """
            <div class="h-px w-full bg-gradient-to-r from-transparent via-cyan-400 to-transparent shadow-[0_0_14px_rgba(34,211,238,0.8)]"></div>
            """
        },

        new Recipe
        {
            Id = 180,
            Name = "Floating Glow Orb",
            Category = "Special Effects",
            Description = "Decorative blurred gradient orb for modern backgrounds.",
            Accent = "gradient",
            Preview = """
            <div class="relative h-44 w-full overflow-hidden rounded-3xl bg-slate-950">
                <div class="absolute left-1/2 top-1/2 size-28 -translate-x-1/2 -translate-y-1/2 rounded-full bg-gradient-to-br from-cyan-400 via-violet-500 to-emerald-400 blur-xl"></div>

                <div class="absolute left-1/2 top-1/2 size-16 -translate-x-1/2 -translate-y-1/2 rounded-full bg-white/70 blur-md"></div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden bg-slate-950">
                <div class="absolute left-1/2 top-1/2 size-28 -translate-x-1/2 -translate-y-1/2 rounded-full bg-gradient-to-br from-cyan-400 via-violet-500 to-emerald-400 blur-xl"></div>

                <div class="absolute left-1/2 top-1/2 size-16 -translate-x-1/2 -translate-y-1/2 rounded-full bg-white/70 blur-md"></div>

                <div class="relative">
                    Content
                </div>
            </div>
            """
        }
    ];
}