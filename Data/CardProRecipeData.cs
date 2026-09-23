public static class CardProRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 165,
            Name = "Project Card",
            Category = "Cards Pro",
            Description = "Project overview card with status and quick action.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-start justify-between">
                    <div class="flex size-11 items-center justify-center rounded-xl bg-cyan-100 text-sm font-extrabold text-cyan-700">
                        TR
                    </div>

                    <span class="rounded-full bg-emerald-100 px-3 py-1 text-[10px] font-bold text-emerald-700">
                        Active
                    </span>
                </div>

                <div class="mt-6 text-lg font-extrabold text-slate-950">
                    Tailwind Recipe Lab
                </div>

                <div class="mt-2 text-sm leading-6 text-slate-500">
                    Reusable frontend recipes and interface patterns.
                </div>

                <button class="mt-6 text-xs font-bold text-cyan-600">
                    Open project →
                </button>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-start justify-between">
                    <div class="flex size-11 items-center justify-center rounded-xl bg-cyan-100 text-sm font-extrabold text-cyan-700">
                        TR
                    </div>

                    <span class="rounded-full bg-emerald-100 px-3 py-1 text-[10px] font-bold text-emerald-700">
                        Active
                    </span>
                </div>

                <div class="mt-6 text-lg font-extrabold text-slate-950">
                    Tailwind Recipe Lab
                </div>

                <div class="mt-2 text-sm leading-6 text-slate-500">
                    Reusable frontend recipes and interface patterns.
                </div>

                <button class="mt-6 text-xs font-bold text-cyan-600">
                    Open project →
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 166,
            Name = "Feature Card",
            Category = "Cards Pro",
            Description = "Clean feature card with large visual marker.",
            Accent = "emerald",
            Preview = """
            <div class="w-full rounded-3xl border border-slate-200 bg-white p-7">
                <div class="flex size-14 items-center justify-center rounded-2xl bg-emerald-100 text-xl font-extrabold text-emerald-700">
                    01
                </div>

                <h3 class="mt-8 text-xl font-extrabold tracking-tight text-slate-950">
                    Fast setup
                </h3>

                <p class="mt-3 text-sm leading-6 text-slate-500">
                    Start a reusable interface without rebuilding common UI patterns.
                </p>
            </div>
            """,
            Code = """
            <div class="rounded-3xl border border-slate-200 bg-white p-7">
                <div class="flex size-14 items-center justify-center rounded-2xl bg-emerald-100 text-xl font-extrabold text-emerald-700">
                    01
                </div>

                <h3 class="mt-8 text-xl font-extrabold tracking-tight text-slate-950">
                    Fast setup
                </h3>

                <p class="mt-3 text-sm leading-6 text-slate-500">
                    Start a reusable interface without rebuilding common UI patterns.
                </p>
            </div>
            """
        },

        new Recipe
        {
            Id = 167,
            Name = "Selectable Card",
            Category = "Cards Pro",
            Description = "Selectable option card for plans and configuration.",
            Accent = "cyan",
            Preview = """
            <label class="block cursor-pointer">
                <input type="radio" name="option-preview" checked class="peer sr-only">

                <div class="rounded-2xl border border-slate-200 bg-white p-5 transition peer-checked:border-cyan-400 peer-checked:bg-cyan-50 peer-checked:ring-4 peer-checked:ring-cyan-100">
                    <div class="flex items-center justify-between">
                        <div>
                            <div class="text-sm font-extrabold text-slate-950">
                                Professional
                            </div>
                            <div class="mt-1 text-xs text-slate-500">
                                Advanced project features
                            </div>
                        </div>

                        <div class="size-4 rounded-full border-4 border-cyan-400 bg-white"></div>
                    </div>
                </div>
            </label>
            """,
            Code = """
            <label class="block cursor-pointer">
                <input type="radio" name="plan" class="peer sr-only">

                <div class="rounded-2xl border border-slate-200 bg-white p-5 transition peer-checked:border-cyan-400 peer-checked:bg-cyan-50 peer-checked:ring-4 peer-checked:ring-cyan-100">
                    <div class="flex items-center justify-between">
                        <div>
                            <div class="text-sm font-extrabold text-slate-950">
                                Professional
                            </div>

                            <div class="mt-1 text-xs text-slate-500">
                                Advanced project features
                            </div>
                        </div>

                        <div class="size-4 rounded-full border-4 border-cyan-400 bg-white"></div>
                    </div>
                </div>
            </label>
            """
        },

        new Recipe
        {
            Id = 168,
            Name = "Dark Metric Card",
            Category = "Cards Pro",
            Description = "Dark metric card with cyan ambient glow.",
            Accent = "cyan",
            Preview = """
            <div class="relative w-full overflow-hidden rounded-2xl bg-slate-950 p-7">
                <div class="absolute -right-10 -top-10 size-32 rounded-full bg-cyan-400/20 blur-3xl"></div>

                <div class="relative">
                    <div class="text-xs font-bold uppercase tracking-widest text-slate-500">
                        Requests
                    </div>

                    <div class="mt-4 text-4xl font-extrabold tracking-tight text-white">
                        84.2K
                    </div>

                    <div class="mt-3 text-xs font-bold text-cyan-300">
                        +12.6% this week
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden rounded-2xl bg-slate-950 p-7">
                <div class="absolute -right-10 -top-10 size-32 rounded-full bg-cyan-400/20 blur-3xl"></div>

                <div class="relative">
                    <div class="text-xs font-bold uppercase tracking-widest text-slate-500">
                        Requests
                    </div>

                    <div class="mt-4 text-4xl font-extrabold tracking-tight text-white">
                        84.2K
                    </div>

                    <div class="mt-3 text-xs font-bold text-cyan-300">
                        +12.6% this week
                    </div>
                </div>
            </div>
            """
        }
    ];
}