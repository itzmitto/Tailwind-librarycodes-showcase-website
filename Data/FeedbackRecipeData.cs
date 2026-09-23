public static class FeedbackRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 60,
            Name = "Info Alert",
            Category = "Alerts",
            Description = "Cyan informational alert block.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-2xl border border-cyan-200 bg-cyan-50 p-5">
                <div class="font-bold text-cyan-900">
                    New version available
                </div>
                <p class="mt-1 text-sm leading-6 text-cyan-700">
                    Refresh the project to load the latest changes.
                </p>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-cyan-200 bg-cyan-50 p-5">
                <div class="font-bold text-cyan-900">
                    New version available
                </div>
                <p class="mt-1 text-sm leading-6 text-cyan-700">
                    Refresh the project to load the latest changes.
                </p>
            </div>
            """
        },

        new Recipe
        {
            Id = 61,
            Name = "Warning Alert",
            Category = "Alerts",
            Description = "Amber warning message for destructive or risky actions.",
            Accent = "amber",
            Preview = """
            <div class="w-full rounded-2xl border border-amber-200 bg-amber-50 p-5">
                <div class="font-bold text-amber-900">
                    Unsaved changes
                </div>
                <p class="mt-1 text-sm text-amber-700">
                    Save before leaving this page.
                </p>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-amber-200 bg-amber-50 p-5">
                <div class="font-bold text-amber-900">
                    Unsaved changes
                </div>
                <p class="mt-1 text-sm text-amber-700">
                    Save before leaving this page.
                </p>
            </div>
            """
        },

        new Recipe
        {
            Id = 62,
            Name = "Error Alert",
            Category = "Alerts",
            Description = "Rose error feedback block.",
            Accent = "rose",
            Preview = """
            <div class="w-full rounded-2xl border border-rose-200 bg-rose-50 p-5">
                <div class="font-bold text-rose-900">
                    Upload failed
                </div>
                <p class="mt-1 text-sm text-rose-700">
                    Check the file and try again.
                </p>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-rose-200 bg-rose-50 p-5">
                <div class="font-bold text-rose-900">
                    Upload failed
                </div>
                <p class="mt-1 text-sm text-rose-700">
                    Check the file and try again.
                </p>
            </div>
            """
        },

        new Recipe
        {
            Id = 63,
            Name = "Action Toast",
            Category = "Toasts",
            Description = "Toast notification with secondary action.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full max-w-md items-center justify-between gap-5 rounded-2xl border border-slate-200 bg-white p-4 shadow-xl shadow-slate-200/70">
                <div>
                    <div class="text-sm font-bold text-slate-900">
                        File deleted
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        The file was moved to trash.
                    </div>
                </div>
                <button class="text-xs font-bold text-cyan-600 hover:text-cyan-700">
                    Undo
                </button>
            </div>
            """,
            Code = """
            <div class="flex items-center justify-between gap-5 rounded-2xl border border-slate-200 bg-white p-4 shadow-xl shadow-slate-200/70">
                <div>
                    <div class="text-sm font-bold text-slate-900">
                        File deleted
                    </div>
                    <div class="mt-1 text-xs text-slate-400">
                        The file was moved to trash.
                    </div>
                </div>
                <button class="text-xs font-bold text-cyan-600 hover:text-cyan-700">
                    Undo
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 64,
            Name = "Notification Dot",
            Category = "Badges",
            Description = "Small notification counter for buttons and icons.",
            Accent = "rose",
            Preview = """
            <button class="relative rounded-xl border border-slate-200 bg-white px-5 py-3 text-sm font-bold text-slate-700">
                Messages
                <span class="absolute -right-2 -top-2 flex size-6 items-center justify-center rounded-full bg-rose-500 text-[10px] font-bold text-white">
                    4
                </span>
            </button>
            """,
            Code = """
            <button class="relative rounded-xl border border-slate-200 bg-white px-5 py-3 text-sm font-bold text-slate-700">
                Messages
                <span class="absolute -right-2 -top-2 flex size-6 items-center justify-center rounded-full bg-rose-500 text-[10px] font-bold text-white">
                    4
                </span>
            </button>
            """
        },

        new Recipe
        {
            Id = 65,
            Name = "Profile Skeleton",
            Category = "Loading",
            Description = "Skeleton loader for profile and list content.",
            Accent = "slate",
            Preview = """
            <div class="flex w-full animate-pulse items-center gap-4">
                <div class="size-12 rounded-full bg-slate-200"></div>
                <div class="flex-1 space-y-2">
                    <div class="h-3 w-1/3 rounded-full bg-slate-200"></div>
                    <div class="h-3 w-2/3 rounded-full bg-slate-200"></div>
                </div>
            </div>
            """,
            Code = """
            <div class="flex animate-pulse items-center gap-4">
                <div class="size-12 rounded-full bg-slate-200"></div>
                <div class="flex-1 space-y-2">
                    <div class="h-3 w-1/3 rounded-full bg-slate-200"></div>
                    <div class="h-3 w-2/3 rounded-full bg-slate-200"></div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 66,
            Name = "Loading Dots",
            Category = "Loading",
            Description = "Minimal three-dot loading indicator.",
            Accent = "cyan",
            Preview = """
            <div class="flex items-center gap-2">
                <span class="size-2 animate-bounce rounded-full bg-cyan-400"></span>
                <span class="size-2 animate-bounce rounded-full bg-cyan-400 [animation-delay:120ms]"></span>
                <span class="size-2 animate-bounce rounded-full bg-cyan-400 [animation-delay:240ms]"></span>
            </div>
            """,
            Code = """
            <div class="flex items-center gap-2">
                <span class="size-2 animate-bounce rounded-full bg-cyan-400"></span>
                <span class="size-2 animate-bounce rounded-full bg-cyan-400 [animation-delay:120ms]"></span>
                <span class="size-2 animate-bounce rounded-full bg-cyan-400 [animation-delay:240ms]"></span>
            </div>
            """
        },

        new Recipe
        {
            Id = 67,
            Name = "Step Progress",
            Category = "Progress",
            Description = "Multi-step progress indicator for forms and checkout flows.",
            Accent = "emerald",
            Preview = """
            <div class="flex w-full items-center">
                <div class="flex size-8 items-center justify-center rounded-full bg-emerald-400 text-xs font-bold text-slate-950">
                    1
                </div>
                <div class="h-1 flex-1 bg-emerald-400"></div>
                <div class="flex size-8 items-center justify-center rounded-full bg-emerald-400 text-xs font-bold text-slate-950">
                    2
                </div>
                <div class="h-1 flex-1 bg-slate-200"></div>
                <div class="flex size-8 items-center justify-center rounded-full bg-slate-200 text-xs font-bold text-slate-500">
                    3
                </div>
            </div>
            """,
            Code = """
            <div class="flex items-center">
                <div class="flex size-8 items-center justify-center rounded-full bg-emerald-400 text-xs font-bold text-slate-950">
                    1
                </div>
                <div class="h-1 flex-1 bg-emerald-400"></div>
                <div class="flex size-8 items-center justify-center rounded-full bg-emerald-400 text-xs font-bold text-slate-950">
                    2
                </div>
                <div class="h-1 flex-1 bg-slate-200"></div>
                <div class="flex size-8 items-center justify-center rounded-full bg-slate-200 text-xs font-bold text-slate-500">
                    3
                </div>
            </div>
            """
        }
    ];
}