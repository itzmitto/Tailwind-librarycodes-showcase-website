public static class ExperimentalRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 130,
            Name = "Floating Island",
            Category = "Experimental",
            Description = "Floating interface surface with deep layered shadow.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-3xl bg-slate-100 p-10">
                <div class="rounded-2xl border border-white bg-white p-6 shadow-[0_30px_70px_-25px_rgba(15,23,42,0.35)] transition hover:-translate-y-2">
                    <div class="text-xs font-bold uppercase tracking-widest text-cyan-600">
                        Floating
                    </div>
                    <div class="mt-8 text-xl font-extrabold text-slate-950">
                        Interface Island
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-white bg-white p-6 shadow-[0_30px_70px_-25px_rgba(15,23,42,0.35)] transition hover:-translate-y-2">
                Content
            </div>
            """
        },

        new Recipe
        {
            Id = 131,
            Name = "Split Glow",
            Category = "Experimental",
            Description = "Two-sided colored lighting for dark panels.",
            Accent = "gradient",
            Preview = """
            <div class="relative overflow-hidden rounded-3xl bg-slate-950 p-8">
                <div class="absolute -left-20 top-0 h-full w-40 bg-cyan-500/30 blur-3xl"></div>
                <div class="absolute -right-20 top-0 h-full w-40 bg-emerald-500/30 blur-3xl"></div>
                <div class="relative text-center text-2xl font-extrabold text-white">
                    Split Glow
                </div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden rounded-3xl bg-slate-950 p-8">
                <div class="absolute -left-20 top-0 h-full w-40 bg-cyan-500/30 blur-3xl"></div>
                <div class="absolute -right-20 top-0 h-full w-40 bg-emerald-500/30 blur-3xl"></div>

                <div class="relative">
                    Content
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 132,
            Name = "Layered Card",
            Category = "Experimental",
            Description = "Stacked card illusion using offset layers.",
            Accent = "cyan",
            Preview = """
            <div class="relative mx-auto w-64 pt-5">
                <div class="absolute inset-x-5 top-0 h-full rounded-2xl bg-cyan-100"></div>
                <div class="absolute inset-x-2.5 top-2.5 h-full rounded-2xl bg-cyan-200"></div>
                <div class="relative rounded-2xl border border-slate-200 bg-white p-6 shadow-lg">
                    <div class="text-lg font-extrabold text-slate-950">
                        Layered
                    </div>
                    <div class="mt-2 text-sm text-slate-500">
                        Three surfaces in one component.
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="relative w-64 pt-5">
                <div class="absolute inset-x-5 top-0 h-full rounded-2xl bg-cyan-100"></div>
                <div class="absolute inset-x-2.5 top-2.5 h-full rounded-2xl bg-cyan-200"></div>

                <div class="relative rounded-2xl border border-slate-200 bg-white p-6 shadow-lg">
                    Content
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 133,
            Name = "Soft Mesh",
            Category = "Experimental",
            Description = "Mesh-like gradient background built from blurred layers.",
            Accent = "gradient",
            Preview = """
            <div class="relative h-44 overflow-hidden rounded-3xl bg-slate-50">
                <div class="absolute -left-5 -top-5 size-36 rounded-full bg-cyan-300 blur-3xl"></div>
                <div class="absolute right-4 top-2 size-36 rounded-full bg-violet-300 blur-3xl"></div>
                <div class="absolute bottom-0 left-1/3 size-36 rounded-full bg-emerald-300 blur-3xl"></div>
                <div class="absolute inset-0 bg-white/25 backdrop-blur-2xl"></div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden bg-slate-50">
                <div class="absolute -left-5 -top-5 size-36 rounded-full bg-cyan-300 blur-3xl"></div>
                <div class="absolute right-4 top-2 size-36 rounded-full bg-violet-300 blur-3xl"></div>
                <div class="absolute bottom-0 left-1/3 size-36 rounded-full bg-emerald-300 blur-3xl"></div>
                <div class="absolute inset-0 bg-white/25 backdrop-blur-2xl"></div>

                <div class="relative">
                    Content
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 134,
            Name = "Floating Label Badge",
            Category = "Experimental",
            Description = "Card with an overlapping category label.",
            Accent = "emerald",
            Preview = """
            <div class="relative mt-4 rounded-2xl border border-slate-200 bg-white p-6">
                <span class="absolute -top-3 left-5 rounded-full bg-emerald-400 px-3 py-1 text-[10px] font-bold uppercase tracking-widest text-slate-950">
                    Featured
                </span>
                <div class="mt-3 text-xl font-extrabold text-slate-950">
                    Project Card
                </div>
                <p class="mt-2 text-sm text-slate-500">
                    Badge overlaps the main surface.
                </p>
            </div>
            """,
            Code = """
            <div class="relative mt-4 rounded-2xl border border-slate-200 bg-white p-6">
                <span class="absolute -top-3 left-5 rounded-full bg-emerald-400 px-3 py-1 text-[10px] font-bold uppercase tracking-widest text-slate-950">
                    Featured
                </span>

                <div class="mt-3 text-xl font-extrabold text-slate-950">
                    Project Card
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 135,
            Name = "Gradient Glass Panel",
            Category = "Experimental",
            Description = "Gradient-backed translucent panel combining glass and glow.",
            Accent = "gradient",
            Preview = """
            <div class="relative overflow-hidden rounded-3xl bg-slate-950 p-8">
                <div class="absolute left-0 top-0 size-40 rounded-full bg-cyan-500/40 blur-3xl"></div>
                <div class="absolute bottom-0 right-0 size-40 rounded-full bg-emerald-500/30 blur-3xl"></div>
                <div class="relative rounded-2xl border border-white/15 bg-gradient-to-br from-white/15 to-white/5 p-6 shadow-2xl backdrop-blur-xl">
                    <div class="text-xs font-bold uppercase tracking-widest text-cyan-300">
                        Hybrid
                    </div>
                    <div class="mt-8 text-2xl font-extrabold text-white">
                        Gradient Glass
                    </div>
                    <p class="mt-2 text-sm text-slate-300">
                        Glow, gradient and glass combined.
                    </p>
                </div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden rounded-3xl bg-slate-950 p-8">
                <div class="absolute left-0 top-0 size-40 rounded-full bg-cyan-500/40 blur-3xl"></div>
                <div class="absolute bottom-0 right-0 size-40 rounded-full bg-emerald-500/30 blur-3xl"></div>

                <div class="relative rounded-2xl border border-white/15 bg-gradient-to-br from-white/15 to-white/5 p-6 shadow-2xl backdrop-blur-xl">
                    Content
                </div>
            </div>
            """
        }
    ];
}