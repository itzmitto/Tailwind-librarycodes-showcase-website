public static class GradientRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 118,
            Name = "Aurora Card",
            Category = "Holographic",
            Description = "Soft aurora gradient surface with cyan, violet and emerald.",
            Accent = "gradient",
            Preview = """
            <div class="relative overflow-hidden rounded-3xl bg-slate-950 p-8">
                <div class="absolute -left-10 top-0 size-40 rounded-full bg-cyan-400/40 blur-3xl"></div>
                <div class="absolute right-0 top-4 size-36 rounded-full bg-violet-500/40 blur-3xl"></div>
                <div class="absolute bottom-0 left-1/3 size-36 rounded-full bg-emerald-400/30 blur-3xl"></div>
                <div class="relative rounded-2xl border border-white/10 bg-white/5 p-6 backdrop-blur-xl">
                    <div class="text-xs font-bold uppercase tracking-widest text-cyan-200">
                        Aurora
                    </div>
                    <div class="mt-10 text-2xl font-extrabold text-white">
                        Northern Interface
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden rounded-3xl bg-slate-950 p-8">
                <div class="absolute -left-10 top-0 size-40 rounded-full bg-cyan-400/40 blur-3xl"></div>
                <div class="absolute right-0 top-4 size-36 rounded-full bg-violet-500/40 blur-3xl"></div>
                <div class="absolute bottom-0 left-1/3 size-36 rounded-full bg-emerald-400/30 blur-3xl"></div>

                <div class="relative rounded-2xl border border-white/10 bg-white/5 p-6 backdrop-blur-xl">
                    Content
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 119,
            Name = "Holographic Badge",
            Category = "Holographic",
            Description = "Iridescent gradient badge for premium labels.",
            Accent = "gradient",
            Preview = """
            <span class="rounded-full bg-gradient-to-r from-cyan-300 via-violet-300 to-emerald-300 px-4 py-2 text-xs font-extrabold uppercase tracking-widest text-slate-950 shadow-lg">
                Premium
            </span>
            """,
            Code = """
            <span class="rounded-full bg-gradient-to-r from-cyan-300 via-violet-300 to-emerald-300 px-4 py-2 text-xs font-extrabold uppercase tracking-widest text-slate-950 shadow-lg">
                Premium
            </span>
            """
        },

        new Recipe
        {
            Id = 120,
            Name = "Holographic Border",
            Category = "Holographic",
            Description = "Multicolor gradient frame around a clean card.",
            Accent = "gradient",
            Preview = """
            <div class="rounded-3xl bg-gradient-to-br from-cyan-400 via-violet-500 to-emerald-400 p-[2px]">
                <div class="rounded-[22px] bg-white p-7">
                    <div class="text-xs font-bold uppercase tracking-widest text-violet-500">
                        Holographic
                    </div>
                    <div class="mt-8 text-xl font-extrabold text-slate-950">
                        Prism Surface
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-3xl bg-gradient-to-br from-cyan-400 via-violet-500 to-emerald-400 p-[2px]">
                <div class="rounded-[22px] bg-white p-7">
                    Content
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 121,
            Name = "Sunset Gradient",
            Category = "Gradients",
            Description = "Warm gradient surface from rose through orange.",
            Accent = "rose",
            Preview = """
            <div class="flex h-40 items-end rounded-2xl bg-gradient-to-br from-rose-400 via-orange-300 to-amber-300 p-6">
                <span class="rounded-lg bg-white/70 px-3 py-2 text-xs font-bold text-slate-900 backdrop-blur">
                    Sunset
                </span>
            </div>
            """,
            Code = """
            <div class="bg-gradient-to-br from-rose-400 via-orange-300 to-amber-300">
                Content
            </div>
            """
        },

        new Recipe
        {
            Id = 122,
            Name = "Ocean Gradient",
            Category = "Gradients",
            Description = "Deep ocean gradient from cyan into indigo.",
            Accent = "cyan",
            Preview = """
            <div class="flex h-40 items-end rounded-2xl bg-gradient-to-br from-cyan-400 via-blue-500 to-indigo-700 p-6">
                <span class="rounded-lg bg-white/15 px-3 py-2 text-xs font-bold text-white backdrop-blur">
                    Ocean
                </span>
            </div>
            """,
            Code = """
            <div class="bg-gradient-to-br from-cyan-400 via-blue-500 to-indigo-700">
                Content
            </div>
            """
        },

        new Recipe
        {
            Id = 123,
            Name = "Gradient Divider",
            Category = "Gradients",
            Description = "Simple fading gradient separator.",
            Accent = "gradient",
            Preview = """
            <div class="w-full">
                <div class="h-px w-full bg-gradient-to-r from-transparent via-cyan-400 to-transparent"></div>
            </div>
            """,
            Code = """
            <div class="h-px w-full bg-gradient-to-r from-transparent via-cyan-400 to-transparent"></div>
            """
        }
    ];
}