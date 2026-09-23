public static class VisualEffectRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 104,
            Name = "Gradient Glow Card",
            Category = "Effects",
            Description = "Card with soft cyan and emerald ambient lights.",
            Accent = "gradient",
            Preview = """
            <div class="relative overflow-hidden rounded-2xl border border-slate-200 bg-white p-7">
                <div class="absolute -left-12 -top-12 size-32 rounded-full bg-cyan-300/40 blur-3xl"></div>
                <div class="absolute -bottom-12 -right-12 size-32 rounded-full bg-emerald-300/40 blur-3xl"></div>
                <div class="relative">
                    <div class="text-xs font-bold uppercase tracking-widest text-cyan-600">
                        Glow
                    </div>
                    <h3 class="mt-8 text-xl font-extrabold">
                        Ambient Surface
                    </h3>
                    <p class="mt-2 text-sm text-slate-500">
                        Decorative blurred gradient lights.
                    </p>
                </div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden rounded-2xl border border-slate-200 bg-white p-7">
                <div class="absolute -left-12 -top-12 size-32 rounded-full bg-cyan-300/40 blur-3xl"></div>
                <div class="absolute -bottom-12 -right-12 size-32 rounded-full bg-emerald-300/40 blur-3xl"></div>

                <div class="relative">
                    Content
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 105,
            Name = "Gradient Ring",
            Category = "Effects",
            Description = "Gradient ring around an avatar or icon.",
            Accent = "gradient",
            Preview = """
            <div class="rounded-full bg-gradient-to-br from-cyan-400 via-violet-500 to-emerald-400 p-1">
                <div class="flex size-16 items-center justify-center rounded-full bg-white text-xl font-extrabold text-slate-950">
                    AB
                </div>
            </div>
            """,
            Code = """
            <div class="inline-flex rounded-full bg-gradient-to-br from-cyan-400 via-violet-500 to-emerald-400 p-1">
                <div class="flex size-16 items-center justify-center rounded-full bg-white text-xl font-extrabold text-slate-950">
                    AB
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 106,
            Name = "Spotlight Card",
            Category = "Effects",
            Description = "Dark card with a large soft spotlight.",
            Accent = "cyan",
            Preview = """
            <div class="relative overflow-hidden rounded-2xl bg-slate-950 p-8">
                <div class="absolute left-1/2 top-0 h-40 w-64 -translate-x-1/2 rounded-full bg-cyan-400/20 blur-3xl"></div>
                <div class="relative text-center">
                    <div class="text-xs font-bold uppercase tracking-widest text-cyan-400">
                        Spotlight
                    </div>
                    <div class="mt-6 text-3xl font-extrabold text-white">
                        Focus
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden rounded-2xl bg-slate-950 p-8">
                <div class="absolute left-1/2 top-0 h-40 w-64 -translate-x-1/2 rounded-full bg-cyan-400/20 blur-3xl"></div>

                <div class="relative">
                    Content
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 107,
            Name = "Hover Lift",
            Category = "Effects",
            Description = "Reusable card hover elevation effect.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-2xl border border-slate-200 bg-white p-7 shadow-sm transition duration-300 hover:-translate-y-2 hover:shadow-2xl hover:shadow-slate-200">
                <div class="text-lg font-extrabold text-slate-950">
                    Hover Lift
                </div>
                <p class="mt-2 text-sm text-slate-500">
                    Hover this card.
                </p>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-7 shadow-sm transition duration-300 hover:-translate-y-2 hover:shadow-2xl hover:shadow-slate-200">
                Content
            </div>
            """
        },

        new Recipe
        {
            Id = 108,
            Name = "Hover Scale",
            Category = "Effects",
            Description = "Small reusable scale interaction.",
            Accent = "emerald",
            Preview = """
            <button class="rounded-xl bg-emerald-400 px-6 py-3 text-sm font-bold text-slate-950 transition duration-200 hover:scale-105 active:scale-95">
                Hover me
            </button>
            """,
            Code = """
            <button class="rounded-xl bg-emerald-400 px-6 py-3 text-sm font-bold text-slate-950 transition duration-200 hover:scale-105 active:scale-95">
                Hover me
            </button>
            """
        },

        new Recipe
        {
            Id = 109,
            Name = "Blur Background",
            Category = "Effects",
            Description = "Decorative blurred background blobs.",
            Accent = "gradient",
            Preview = """
            <div class="relative h-44 w-full overflow-hidden rounded-2xl bg-slate-950">
                <div class="absolute left-6 top-8 size-28 rounded-full bg-cyan-400/40 blur-3xl"></div>
                <div class="absolute bottom-4 right-8 size-32 rounded-full bg-fuchsia-500/30 blur-3xl"></div>
                <div class="absolute inset-0 flex items-center justify-center">
                    <span class="text-xl font-extrabold text-white">
                        Background Blur
                    </span>
                </div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden bg-slate-950">
                <div class="absolute left-6 top-8 size-28 rounded-full bg-cyan-400/40 blur-3xl"></div>
                <div class="absolute bottom-4 right-8 size-32 rounded-full bg-fuchsia-500/30 blur-3xl"></div>

                <div class="relative">
                    Content
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 110,
            Name = "Gradient Text",
            Category = "Effects",
            Description = "Bright multicolor gradient heading.",
            Accent = "gradient",
            Preview = """
            <div class="text-center">
                <h3 class="bg-gradient-to-r from-cyan-500 via-blue-500 to-emerald-500 bg-clip-text text-5xl font-extrabold tracking-[-0.06em] text-transparent">
                    Create More
                </h3>
            </div>
            """,
            Code = """
            <h3 class="bg-gradient-to-r from-cyan-500 via-blue-500 to-emerald-500 bg-clip-text text-5xl font-extrabold tracking-[-0.06em] text-transparent">
                Create More
            </h3>
            """
        },

        new Recipe
        {
            Id = 111,
            Name = "Inset Highlight",
            Category = "Effects",
            Description = "Subtle inset highlight for polished UI surfaces.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-2xl border border-slate-200 bg-gradient-to-b from-white to-slate-50 p-7 shadow-[inset_0_1px_0_rgba(255,255,255,1),0_10px_30px_rgba(15,23,42,0.08)]">
                <div class="text-lg font-extrabold text-slate-950">
                    Polished Surface
                </div>
                <p class="mt-2 text-sm text-slate-500">
                    Soft inset highlight with an outer shadow.
                </p>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-gradient-to-b from-white to-slate-50 p-7 shadow-[inset_0_1px_0_rgba(255,255,255,1),0_10px_30px_rgba(15,23,42,0.08)]">
                Content
            </div>
            """
        }
    ];
}