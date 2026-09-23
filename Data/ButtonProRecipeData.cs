public static class ButtonProRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 161,
            Name = "Icon Action Button",
            Category = "Buttons Pro",
            Description = "Primary action button with a compact icon block.",
            Accent = "cyan",
            Preview = """
            <button class="inline-flex items-center gap-3 rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950 transition hover:bg-cyan-300 active:scale-95">
                <span class="flex size-7 items-center justify-center rounded-lg bg-white/50">
                    +
                </span>
                New project
            </button>
            """,
            Code = """
            <button class="inline-flex items-center gap-3 rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950 transition hover:bg-cyan-300 active:scale-95">
                <span class="flex size-7 items-center justify-center rounded-lg bg-white/50">
                    +
                </span>
                New project
            </button>
            """
        },

        new Recipe
        {
            Id = 162,
            Name = "Loading Button",
            Category = "Buttons Pro",
            Description = "Button pattern for loading and submitting states.",
            Accent = "cyan",
            Preview = """
            <button class="inline-flex items-center gap-3 rounded-xl bg-slate-950 px-5 py-3 text-sm font-bold text-white">
                <span class="size-4 animate-spin rounded-full border-2 border-white/30 border-t-cyan-400"></span>
                Saving
            </button>
            """,
            Code = """
            <button
                disabled
                class="inline-flex items-center gap-3 rounded-xl bg-slate-950 px-5 py-3 text-sm font-bold text-white disabled:cursor-not-allowed disabled:opacity-80"
            >
                <span class="size-4 animate-spin rounded-full border-2 border-white/30 border-t-cyan-400"></span>
                Saving
            </button>
            """
        },

        new Recipe
        {
            Id = 163,
            Name = "Split Button",
            Category = "Buttons Pro",
            Description = "Primary action button with a separate dropdown trigger.",
            Accent = "emerald",
            Preview = """
            <div class="inline-flex overflow-hidden rounded-xl bg-emerald-400 text-slate-950">
                <button class="px-5 py-3 text-sm font-bold transition hover:bg-emerald-300">
                    Publish
                </button>
                <button class="border-l border-emerald-500/40 px-3 py-3 text-sm font-bold transition hover:bg-emerald-300">
                    ▾
                </button>
            </div>
            """,
            Code = """
            <div class="inline-flex overflow-hidden rounded-xl bg-emerald-400 text-slate-950">
                <button class="px-5 py-3 text-sm font-bold transition hover:bg-emerald-300">
                    Publish
                </button>

                <button class="border-l border-emerald-500/40 px-3 py-3 text-sm font-bold transition hover:bg-emerald-300">
                    ▾
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 164,
            Name = "Danger Button",
            Category = "Buttons Pro",
            Description = "Destructive action button with soft danger styling.",
            Accent = "rose",
            Preview = """
            <button class="rounded-xl border border-rose-200 bg-rose-50 px-5 py-3 text-sm font-bold text-rose-700 transition hover:border-rose-300 hover:bg-rose-100 active:scale-95">
                Delete project
            </button>
            """,
            Code = """
            <button class="rounded-xl border border-rose-200 bg-rose-50 px-5 py-3 text-sm font-bold text-rose-700 transition hover:border-rose-300 hover:bg-rose-100 active:scale-95">
                Delete project
            </button>
            """
        }
    ];
}