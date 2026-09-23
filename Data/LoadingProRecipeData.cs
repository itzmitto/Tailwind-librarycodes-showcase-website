public static class LoadingProRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 173,
            Name = "Dual Ring Loader",
            Category = "Loading Pro",
            Description = "Two layered spinning rings with cyan and emerald accents.",
            Accent = "cyan",
            Preview = """
            <div class="relative size-14">
                <div class="absolute inset-0 animate-spin rounded-full border-4 border-slate-200 border-t-cyan-400"></div>
                <div class="absolute inset-2 animate-spin rounded-full border-4 border-slate-100 border-b-emerald-400 [animation-direction:reverse]"></div>
            </div>
            """,
            Code = """
            <div class="relative size-14">
                <div class="absolute inset-0 animate-spin rounded-full border-4 border-slate-200 border-t-cyan-400"></div>

                <div class="absolute inset-2 animate-spin rounded-full border-4 border-slate-100 border-b-emerald-400 [animation-direction:reverse]"></div>
            </div>
            """
        },

        new Recipe
        {
            Id = 174,
            Name = "Loading Card",
            Category = "Loading Pro",
            Description = "Full card loading placeholder for dashboard content.",
            Accent = "slate",
            Preview = """
            <div class="w-full animate-pulse rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-center gap-4">
                    <div class="size-12 rounded-xl bg-slate-200"></div>

                    <div class="flex-1 space-y-2">
                        <div class="h-3 w-1/2 rounded bg-slate-200"></div>
                        <div class="h-3 w-1/3 rounded bg-slate-100"></div>
                    </div>
                </div>

                <div class="mt-7 h-24 rounded-xl bg-slate-100"></div>
            </div>
            """,
            Code = """
            <div class="animate-pulse rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-center gap-4">
                    <div class="size-12 rounded-xl bg-slate-200"></div>

                    <div class="flex-1 space-y-2">
                        <div class="h-3 w-1/2 rounded bg-slate-200"></div>
                        <div class="h-3 w-1/3 rounded bg-slate-100"></div>
                    </div>
                </div>

                <div class="mt-7 h-24 rounded-xl bg-slate-100"></div>
            </div>
            """
        },

        new Recipe
        {
            Id = 175,
            Name = "Typing Loader",
            Category = "Loading Pro",
            Description = "Three animated dots for chat and messaging interfaces.",
            Accent = "cyan",
            Preview = """
            <div class="inline-flex items-center gap-1.5 rounded-2xl bg-slate-100 px-4 py-3">
                <span class="size-2 animate-bounce rounded-full bg-cyan-400"></span>
                <span class="size-2 animate-bounce rounded-full bg-cyan-400 [animation-delay:120ms]"></span>
                <span class="size-2 animate-bounce rounded-full bg-cyan-400 [animation-delay:240ms]"></span>
            </div>
            """,
            Code = """
            <div class="inline-flex items-center gap-1.5 rounded-2xl bg-slate-100 px-4 py-3">
                <span class="size-2 animate-bounce rounded-full bg-cyan-400"></span>
                <span class="size-2 animate-bounce rounded-full bg-cyan-400 [animation-delay:120ms]"></span>
                <span class="size-2 animate-bounce rounded-full bg-cyan-400 [animation-delay:240ms]"></span>
            </div>
            """
        },

        new Recipe
        {
            Id = 176,
            Name = "Dark Loading Bar",
            Category = "Loading Pro",
            Description = "Dark progress loader with cyan glow.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl bg-slate-950 p-7">
                <div class="flex items-center justify-between">
                    <span class="text-xs font-bold text-slate-400">
                        Loading assets
                    </span>

                    <span class="text-xs font-bold text-cyan-300">
                        62%
                    </span>
                </div>

                <div class="mt-4 h-2 overflow-hidden rounded-full bg-white/10">
                    <div class="h-full w-[62%] rounded-full bg-cyan-400 shadow-[0_0_18px_rgba(34,211,238,0.8)]"></div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl bg-slate-950 p-7">
                <div class="flex items-center justify-between">
                    <span class="text-xs font-bold text-slate-400">
                        Loading assets
                    </span>

                    <span class="text-xs font-bold text-cyan-300">
                        62%
                    </span>
                </div>

                <div class="mt-4 h-2 overflow-hidden rounded-full bg-white/10">
                    <div class="h-full w-[62%] rounded-full bg-cyan-400 shadow-[0_0_18px_rgba(34,211,238,0.8)]"></div>
                </div>
            </div>
            """
        }
    ];
}