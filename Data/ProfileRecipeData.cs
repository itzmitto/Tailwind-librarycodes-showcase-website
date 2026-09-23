public static class ProfileRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 146,
            Name = "Developer Profile",
            Category = "Profiles",
            Description = "Clean developer profile card with status and skills.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-center gap-4">
                    <div class="flex size-14 items-center justify-center rounded-2xl bg-cyan-100 text-lg font-extrabold text-cyan-700">
                        AB
                    </div>

                    <div>
                        <div class="font-extrabold text-slate-950">
                            Andre
                        </div>
                        <div class="mt-1 text-xs text-slate-400">
                            Frontend Developer
                        </div>
                    </div>
                </div>

                <div class="mt-6 flex flex-wrap gap-2">
                    <span class="rounded-full bg-cyan-50 px-3 py-1 text-[10px] font-bold text-cyan-700">
                        React
                    </span>
                    <span class="rounded-full bg-emerald-50 px-3 py-1 text-[10px] font-bold text-emerald-700">
                        Tailwind
                    </span>
                    <span class="rounded-full bg-violet-50 px-3 py-1 text-[10px] font-bold text-violet-700">
                        TypeScript
                    </span>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-center gap-4">
                    <div class="flex size-14 items-center justify-center rounded-2xl bg-cyan-100 text-lg font-extrabold text-cyan-700">
                        AB
                    </div>

                    <div>
                        <div class="font-extrabold text-slate-950">
                            Andre
                        </div>
                        <div class="mt-1 text-xs text-slate-400">
                            Frontend Developer
                        </div>
                    </div>
                </div>

                <div class="mt-6 flex flex-wrap gap-2">
                    <span class="rounded-full bg-cyan-50 px-3 py-1 text-[10px] font-bold text-cyan-700">
                        React
                    </span>
                    <span class="rounded-full bg-emerald-50 px-3 py-1 text-[10px] font-bold text-emerald-700">
                        Tailwind
                    </span>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 147,
            Name = "Profile Stats",
            Category = "Profiles",
            Description = "User profile card with followers and project statistics.",
            Accent = "emerald",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-6 text-center">
                <div class="mx-auto flex size-16 items-center justify-center rounded-full bg-gradient-to-br from-cyan-300 to-emerald-300 text-xl font-extrabold text-slate-950">
                    AB
                </div>

                <div class="mt-4 font-extrabold text-slate-950">
                    Andre
                </div>

                <div class="mt-1 text-xs text-slate-400">
                    @developer
                </div>

                <div class="mt-6 grid grid-cols-3 divide-x divide-slate-100">
                    <div>
                        <div class="font-extrabold">42</div>
                        <div class="mt-1 text-[9px] text-slate-400">Projects</div>
                    </div>

                    <div>
                        <div class="font-extrabold">1.8K</div>
                        <div class="mt-1 text-[9px] text-slate-400">Followers</div>
                    </div>

                    <div>
                        <div class="font-extrabold">128</div>
                        <div class="mt-1 text-[9px] text-slate-400">Following</div>
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6 text-center">
                <div class="mx-auto flex size-16 items-center justify-center rounded-full bg-gradient-to-br from-cyan-300 to-emerald-300 text-xl font-extrabold text-slate-950">
                    AB
                </div>

                <div class="mt-4 font-extrabold text-slate-950">
                    Andre
                </div>

                <div class="mt-6 grid grid-cols-3 divide-x divide-slate-100">
                    <div>
                        <div class="font-extrabold">42</div>
                        <div class="text-[9px] text-slate-400">Projects</div>
                    </div>

                    <div>
                        <div class="font-extrabold">1.8K</div>
                        <div class="text-[9px] text-slate-400">Followers</div>
                    </div>

                    <div>
                        <div class="font-extrabold">128</div>
                        <div class="text-[9px] text-slate-400">Following</div>
                    </div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 148,
            Name = "Team Member",
            Category = "Profiles",
            Description = "Compact team member row with online status.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="relative">
                    <div class="flex size-12 items-center justify-center rounded-full bg-emerald-100 font-bold text-emerald-700">
                        JD
                    </div>
                    <div class="absolute bottom-0 right-0 size-3 rounded-full border-2 border-white bg-emerald-400"></div>
                </div>

                <div class="min-w-0 flex-1">
                    <div class="text-sm font-bold text-slate-950">
                        Jane Doe
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        UI Designer
                    </div>
                </div>

                <button class="rounded-lg border border-slate-200 px-3 py-2 text-xs font-bold text-slate-500">
                    View
                </button>
            </div>
            """,
            Code = """
            <div class="flex items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="relative">
                    <img
                        src="/avatar.jpg"
                        alt=""
                        class="size-12 rounded-full object-cover"
                    >

                    <div class="absolute bottom-0 right-0 size-3 rounded-full border-2 border-white bg-emerald-400"></div>
                </div>

                <div class="min-w-0 flex-1">
                    <div class="text-sm font-bold text-slate-950">
                        Jane Doe
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        UI Designer
                    </div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 149,
            Name = "Profile Completion",
            Category = "Profiles",
            Description = "Profile completion card with progress and action.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-center justify-between">
                    <div class="font-extrabold text-slate-950">
                        Complete profile
                    </div>

                    <span class="text-sm font-extrabold text-cyan-600">
                        75%
                    </span>
                </div>

                <div class="mt-5 h-2 overflow-hidden rounded-full bg-slate-100">
                    <div class="h-full w-3/4 rounded-full bg-cyan-400"></div>
                </div>

                <button class="mt-5 text-xs font-bold text-cyan-600">
                    Continue setup →
                </button>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex items-center justify-between">
                    <div class="font-extrabold text-slate-950">
                        Complete profile
                    </div>

                    <span class="text-sm font-extrabold text-cyan-600">
                        75%
                    </span>
                </div>

                <div class="mt-5 h-2 overflow-hidden rounded-full bg-slate-100">
                    <div class="h-full w-3/4 rounded-full bg-cyan-400"></div>
                </div>

                <button class="mt-5 text-xs font-bold text-cyan-600">
                    Continue setup →
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 150,
            Name = "Dark Profile Card",
            Category = "Profiles",
            Description = "Dark profile card with neon cyan accent.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl bg-slate-950 p-6">
                <div class="flex items-center gap-4">
                    <div class="flex size-14 items-center justify-center rounded-2xl border border-cyan-400/30 bg-cyan-400/10 text-lg font-extrabold text-cyan-300 shadow-[0_0_20px_rgba(34,211,238,0.15)]">
                        AB
                    </div>

                    <div>
                        <div class="font-extrabold text-white">
                            Andre
                        </div>
                        <div class="mt-1 text-xs text-cyan-300">
                            Frontend Developer
                        </div>
                    </div>
                </div>

                <div class="mt-6 rounded-xl bg-white/5 p-4 text-xs leading-5 text-slate-400">
                    Building reusable interfaces and modern web experiences.
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl bg-slate-950 p-6">
                <div class="flex items-center gap-4">
                    <div class="flex size-14 items-center justify-center rounded-2xl border border-cyan-400/30 bg-cyan-400/10 text-lg font-extrabold text-cyan-300">
                        AB
                    </div>

                    <div>
                        <div class="font-extrabold text-white">
                            Andre
                        </div>
                        <div class="mt-1 text-xs text-cyan-300">
                            Frontend Developer
                        </div>
                    </div>
                </div>
            </div>
            """
        }
    ];
}