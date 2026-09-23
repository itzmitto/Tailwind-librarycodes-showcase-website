public static class MicroInteractionRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 124,
            Name = "Press Button",
            Category = "Micro Interactions",
            Description = "Button with tactile press feedback.",
            Accent = "cyan",
            Preview = """
            <button class="rounded-xl bg-cyan-400 px-6 py-3 text-sm font-bold text-slate-950 shadow-[0_5px_0_rgb(8_145_178)] transition active:translate-y-1 active:shadow-none">
                Press me
            </button>
            """,
            Code = """
            <button class="rounded-xl bg-cyan-400 px-6 py-3 text-sm font-bold text-slate-950 shadow-[0_5px_0_rgb(8_145_178)] transition active:translate-y-1 active:shadow-none">
                Press me
            </button>
            """
        },

        new Recipe
        {
            Id = 125,
            Name = "Hover Arrow",
            Category = "Micro Interactions",
            Description = "Action link with moving arrow on hover.",
            Accent = "cyan",
            Preview = """
            <button class="group inline-flex items-center gap-2 text-sm font-bold text-cyan-600">
                Explore
                <span class="transition-transform group-hover:translate-x-1.5">
                    →
                </span>
            </button>
            """,
            Code = """
            <button class="group inline-flex items-center gap-2 text-sm font-bold text-cyan-600">
                Explore
                <span class="transition-transform group-hover:translate-x-1.5">
                    →
                </span>
            </button>
            """
        },

        new Recipe
        {
            Id = 126,
            Name = "Icon Rotate",
            Category = "Micro Interactions",
            Description = "Hover interaction that rotates an action icon.",
            Accent = "emerald",
            Preview = """
            <button class="group flex items-center gap-3 rounded-xl border border-slate-200 bg-white px-5 py-3 text-sm font-bold text-slate-700">
                Refresh
                <span class="text-lg transition-transform duration-300 group-hover:rotate-180">
                    ↻
                </span>
            </button>
            """,
            Code = """
            <button class="group flex items-center gap-3 rounded-xl border border-slate-200 bg-white px-5 py-3 text-sm font-bold text-slate-700">
                Refresh
                <span class="text-lg transition-transform duration-300 group-hover:rotate-180">
                    ↻
                </span>
            </button>
            """
        },

        new Recipe
        {
            Id = 127,
            Name = "Underline Reveal",
            Category = "Micro Interactions",
            Description = "Text link with animated underline reveal.",
            Accent = "cyan",
            Preview = """
            <a class="group relative text-sm font-bold text-slate-900">
                Documentation
                <span class="absolute -bottom-1 left-0 h-0.5 w-0 bg-cyan-400 transition-all duration-300 group-hover:w-full"></span>
            </a>
            """,
            Code = """
            <a href="#" class="group relative text-sm font-bold text-slate-900">
                Documentation
                <span class="absolute -bottom-1 left-0 h-0.5 w-0 bg-cyan-400 transition-all duration-300 group-hover:w-full"></span>
            </a>
            """
        },

        new Recipe
        {
            Id = 128,
            Name = "Card Image Zoom",
            Category = "Micro Interactions",
            Description = "Image container with smooth hover zoom.",
            Accent = "cyan",
            Preview = """
            <div class="group overflow-hidden rounded-2xl bg-slate-950">
                <div class="flex h-40 items-center justify-center bg-gradient-to-br from-cyan-300 to-emerald-300 transition-transform duration-500 group-hover:scale-110">
                    <span class="text-2xl font-extrabold text-slate-950">
                        Preview
                    </span>
                </div>
            </div>
            """,
            Code = """
            <div class="group overflow-hidden rounded-2xl">
                <img
                    src="/image.jpg"
                    alt=""
                    class="h-full w-full object-cover transition-transform duration-500 group-hover:scale-110"
                >
            </div>
            """
        },

        new Recipe
        {
            Id = 129,
            Name = "Focus Grow Input",
            Category = "Micro Interactions",
            Description = "Compact search field that expands when focused.",
            Accent = "cyan",
            Preview = """
            <input
                type="search"
                placeholder="Search"
                class="w-40 rounded-xl border border-slate-300 bg-white px-4 py-3 text-sm outline-none transition-all duration-300 focus:w-64 focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
            >
            """,
            Code = """
            <input
                type="search"
                placeholder="Search"
                class="w-40 rounded-xl border border-slate-300 bg-white px-4 py-3 text-sm outline-none transition-all duration-300 focus:w-64 focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
            >
            """
        }
    ];
}