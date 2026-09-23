public static class RecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 1,
            Name = "Primary Cyan",
            Category = "Buttons",
            Description = "Bright primary action button.",
            Accent = "cyan",
            Preview = """
            <button class="rounded-xl bg-cyan-400 px-6 py-3 text-sm font-bold text-slate-950 transition hover:bg-cyan-300 active:scale-95">
                Get Started
            </button>
            """,
            Code = """
            <button class="rounded-xl bg-cyan-400 px-6 py-3 text-sm font-bold text-slate-950 transition hover:bg-cyan-300 active:scale-95">
                Get Started
            </button>
            """
        },

        new Recipe
        {
            Id = 2,
            Name = "Secondary Emerald",
            Category = "Buttons",
            Description = "Secondary emerald action button.",
            Accent = "emerald",
            Preview = """
            <button class="rounded-xl bg-emerald-400 px-6 py-3 text-sm font-bold text-slate-950 transition hover:bg-emerald-300 active:scale-95">
                Continue
            </button>
            """,
            Code = """
            <button class="rounded-xl bg-emerald-400 px-6 py-3 text-sm font-bold text-slate-950 transition hover:bg-emerald-300 active:scale-95">
                Continue
            </button>
            """
        },

        new Recipe
        {
            Id = 3,
            Name = "Clean Outline",
            Category = "Buttons",
            Description = "Neutral outline button with cyan interaction.",
            Accent = "cyan",
            Preview = """
            <button class="rounded-xl border border-slate-300 bg-white px-6 py-3 text-sm font-bold text-slate-700 transition hover:border-cyan-400 hover:text-cyan-600 active:scale-95">
                Learn More
            </button>
            """,
            Code = """
            <button class="rounded-xl border border-slate-300 bg-white px-6 py-3 text-sm font-bold text-slate-700 transition hover:border-cyan-400 hover:text-cyan-600 active:scale-95">
                Learn More
            </button>
            """
        },

        new Recipe
        {
            Id = 4,
            Name = "Ghost Button",
            Category = "Buttons",
            Description = "Minimal button for lower-priority actions.",
            Accent = "slate",
            Preview = """
            <button class="rounded-xl px-6 py-3 text-sm font-bold text-slate-600 transition hover:bg-slate-200 hover:text-slate-950 active:scale-95">
                Cancel
            </button>
            """,
            Code = """
            <button class="rounded-xl px-6 py-3 text-sm font-bold text-slate-600 transition hover:bg-slate-200 hover:text-slate-950 active:scale-95">
                Cancel
            </button>
            """
        },

        new Recipe
        {
            Id = 5,
            Name = "Gradient Button",
            Category = "Buttons",
            Description = "Cyan to emerald gradient action.",
            Accent = "gradient",
            Preview = """
            <button class="rounded-xl bg-gradient-to-r from-cyan-400 to-emerald-400 px-6 py-3 text-sm font-bold text-slate-950 transition hover:brightness-105 active:scale-95">
                Create Project
            </button>
            """,
            Code = """
            <button class="rounded-xl bg-gradient-to-r from-cyan-400 to-emerald-400 px-6 py-3 text-sm font-bold text-slate-950 transition hover:brightness-105 active:scale-95">
                Create Project
            </button>
            """
        },

        new Recipe
        {
            Id = 6,
            Name = "Soft Cyan Card",
            Category = "Cards",
            Description = "Clean card with a subtle cyan accent.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex size-11 items-center justify-center rounded-xl bg-cyan-100 font-bold text-cyan-700">
                    01
                </div>
                <h3 class="mt-8 text-xl font-extrabold tracking-tight">
                    Project analytics
                </h3>
                <p class="mt-2 text-sm leading-6 text-slate-500">
                    A clean reusable card for dashboard content.
                </p>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="flex size-11 items-center justify-center rounded-xl bg-cyan-100 font-bold text-cyan-700">
                    01
                </div>
                <h3 class="mt-8 text-xl font-extrabold tracking-tight">
                    Project analytics
                </h3>
                <p class="mt-2 text-sm leading-6 text-slate-500">
                    A clean reusable card for dashboard content.
                </p>
            </div>
            """
        },

        new Recipe
        {
            Id = 7,
            Name = "Elevated Card",
            Category = "Cards",
            Description = "Soft shadow card for elevated content.",
            Accent = "emerald",
            Preview = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6 shadow-xl shadow-slate-200/70">
                <div class="text-sm font-bold text-emerald-600">
                    Active project
                </div>
                <div class="mt-4 text-3xl font-extrabold tracking-tight text-slate-950">
                    84%
                </div>
                <p class="mt-2 text-sm text-slate-500">
                    Development progress
                </p>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6 shadow-xl shadow-slate-200/70">
                <div class="text-sm font-bold text-emerald-600">
                    Active project
                </div>
                <div class="mt-4 text-3xl font-extrabold tracking-tight text-slate-950">
                    84%
                </div>
                <p class="mt-2 text-sm text-slate-500">
                    Development progress
                </p>
            </div>
            """
        },

        new Recipe
        {
            Id = 8,
            Name = "Gradient Border",
            Category = "Cards",
            Description = "Thin cyan and emerald gradient border.",
            Accent = "gradient",
            Preview = """
            <div class="rounded-2xl bg-gradient-to-br from-cyan-400 to-emerald-400 p-[1px]">
                <div class="rounded-[15px] bg-white p-6">
                    <div class="text-xs font-bold uppercase tracking-widest text-cyan-600">
                        Featured
                    </div>
                    <h3 class="mt-8 text-xl font-extrabold">
                        Gradient Border
                    </h3>
                    <p class="mt-2 text-sm leading-6 text-slate-500">
                        A clean border effect without heavy decoration.
                    </p>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-2xl bg-gradient-to-br from-cyan-400 to-emerald-400 p-[1px]">
                <div class="rounded-[15px] bg-white p-6">
                    <div class="text-xs font-bold uppercase tracking-widest text-cyan-600">
                        Featured
                    </div>
                    <h3 class="mt-8 text-xl font-extrabold">
                        Gradient Border
                    </h3>
                    <p class="mt-2 text-sm leading-6 text-slate-500">
                        A clean border effect without heavy decoration.
                    </p>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 9,
            Name = "Clean Input",
            Category = "Inputs",
            Description = "Basic input with cyan focus state.",
            Accent = "cyan",
            Preview = """
            <label class="block">
                <span class="mb-2 block text-sm font-semibold text-slate-700">
                    Email address
                </span>
                <input
                    type="email"
                    placeholder="developer@example.com"
                    class="w-full rounded-xl border border-slate-300 bg-white px-4 py-3 text-sm outline-none transition placeholder:text-slate-400 focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
            </label>
            """,
            Code = """
            <label class="block">
                <span class="mb-2 block text-sm font-semibold text-slate-700">
                    Email address
                </span>
                <input
                    type="email"
                    placeholder="developer@example.com"
                    class="w-full rounded-xl border border-slate-300 bg-white px-4 py-3 text-sm outline-none transition placeholder:text-slate-400 focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
            </label>
            """
        },

        new Recipe
        {
            Id = 10,
            Name = "Search Input",
            Category = "Inputs",
            Description = "Compact search field with embedded icon.",
            Accent = "cyan",
            Preview = """
            <div class="relative">
                <span class="pointer-events-none absolute left-4 top-1/2 -translate-y-1/2 text-slate-400">
                    ⌕
                </span>
                <input
                    type="search"
                    placeholder="Search recipes..."
                    class="w-full rounded-xl border border-slate-300 bg-white py-3 pl-11 pr-4 text-sm outline-none transition focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
            </div>
            """,
            Code = """
            <div class="relative">
                <span class="pointer-events-none absolute left-4 top-1/2 -translate-y-1/2 text-slate-400">
                    ⌕
                </span>
                <input
                    type="search"
                    placeholder="Search recipes..."
                    class="w-full rounded-xl border border-slate-300 bg-white py-3 pl-11 pr-4 text-sm outline-none transition focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >
            </div>
            """
        },

        new Recipe
        {
            Id = 11,
            Name = "Error Input",
            Category = "Inputs",
            Description = "Input field with validation error state.",
            Accent = "rose",
            Preview = """
            <label class="block">
                <span class="mb-2 block text-sm font-semibold text-slate-700">
                    Username
                </span>
                <input
                    type="text"
                    value="ab"
                    class="w-full rounded-xl border border-rose-400 bg-white px-4 py-3 text-sm outline-none ring-4 ring-rose-100"
                >
                <span class="mt-2 block text-xs font-semibold text-rose-600">
                    Username must contain at least 3 characters.
                </span>
            </label>
            """,
            Code = """
            <label class="block">
                <span class="mb-2 block text-sm font-semibold text-slate-700">
                    Username
                </span>
                <input
                    type="text"
                    value="ab"
                    class="w-full rounded-xl border border-rose-400 bg-white px-4 py-3 text-sm outline-none ring-4 ring-rose-100"
                >
                <span class="mt-2 block text-xs font-semibold text-rose-600">
                    Username must contain at least 3 characters.
                </span>
            </label>
            """
        },

        new Recipe
        {
            Id = 12,
            Name = "Cyan Badge",
            Category = "Badges",
            Description = "Soft cyan status badge.",
            Accent = "cyan",
            Preview = """
            <span class="rounded-full bg-cyan-100 px-3 py-1.5 text-xs font-bold text-cyan-700">
                New
            </span>
            """,
            Code = """
            <span class="rounded-full bg-cyan-100 px-3 py-1.5 text-xs font-bold text-cyan-700">
                New
            </span>
            """
        },

        new Recipe
        {
            Id = 13,
            Name = "Emerald Badge",
            Category = "Badges",
            Description = "Emerald badge for success states.",
            Accent = "emerald",
            Preview = """
            <span class="rounded-full bg-emerald-100 px-3 py-1.5 text-xs font-bold text-emerald-700">
                Active
            </span>
            """,
            Code = """
            <span class="rounded-full bg-emerald-100 px-3 py-1.5 text-xs font-bold text-emerald-700">
                Active
            </span>
            """
        },

        new Recipe
        {
            Id = 14,
            Name = "Outline Badge",
            Category = "Badges",
            Description = "Simple reusable outline badge.",
            Accent = "slate",
            Preview = """
            <span class="rounded-full border border-slate-300 bg-white px-3 py-1.5 text-xs font-bold text-slate-600">
                Draft
            </span>
            """,
            Code = """
            <span class="rounded-full border border-slate-300 bg-white px-3 py-1.5 text-xs font-bold text-slate-600">
                Draft
            </span>
            """
        },

        new Recipe
        {
            Id = 15,
            Name = "Glass Surface",
            Category = "Glass",
            Description = "Reusable glassmorphism panel.",
            Accent = "cyan",
            Preview = """
            <div class="relative overflow-hidden rounded-3xl bg-gradient-to-br from-cyan-300 via-sky-200 to-emerald-200 p-8">
                <div class="rounded-2xl border border-white/60 bg-white/40 p-6 shadow-xl backdrop-blur-xl">
                    <div class="text-xs font-bold uppercase tracking-widest text-slate-600">
                        Glass
                    </div>
                    <h3 class="mt-8 text-xl font-extrabold text-slate-950">
                        Glass Surface
                    </h3>
                    <p class="mt-2 text-sm text-slate-600">
                        Frosted transparent panel.
                    </p>
                </div>
            </div>
            """,
            Code = """
            <div class="relative overflow-hidden rounded-3xl bg-gradient-to-br from-cyan-300 via-sky-200 to-emerald-200 p-8">
                <div class="rounded-2xl border border-white/60 bg-white/40 p-6 shadow-xl backdrop-blur-xl">
                    <div class="text-xs font-bold uppercase tracking-widest text-slate-600">
                        Glass
                    </div>
                    <h3 class="mt-8 text-xl font-extrabold text-slate-950">
                        Glass Surface
                    </h3>
                    <p class="mt-2 text-sm text-slate-600">
                        Frosted transparent panel.
                    </p>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 16,
            Name = "Glass Button",
            Category = "Glass",
            Description = "Transparent glass button for colorful backgrounds.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-2xl bg-gradient-to-r from-cyan-400 to-emerald-400 p-10 text-center">
                <button class="rounded-xl border border-white/50 bg-white/25 px-6 py-3 text-sm font-bold text-slate-950 shadow-lg backdrop-blur-lg transition hover:bg-white/40">
                    Explore
                </button>
            </div>
            """,
            Code = """
            <button class="rounded-xl border border-white/50 bg-white/25 px-6 py-3 text-sm font-bold text-slate-950 shadow-lg backdrop-blur-lg transition hover:bg-white/40">
                Explore
            </button>
            """
        },

        new Recipe
        {
            Id = 17,
            Name = "Cyan Emerald Gradient",
            Category = "Gradients",
            Description = "Reusable cyan to emerald background gradient.",
            Accent = "gradient",
            Preview = """
            <div class="flex h-40 items-end rounded-2xl bg-gradient-to-br from-cyan-400 via-cyan-300 to-emerald-400 p-6">
                <span class="rounded-lg bg-white/80 px-3 py-2 text-xs font-bold text-slate-800 backdrop-blur">
                    Cyan → Emerald
                </span>
            </div>
            """,
            Code = """
            <div class="bg-gradient-to-br from-cyan-400 via-cyan-300 to-emerald-400">
                Content
            </div>
            """
        },

        new Recipe
        {
            Id = 18,
            Name = "Text Gradient",
            Category = "Gradients",
            Description = "Gradient text for headings.",
            Accent = "gradient",
            Preview = """
            <h3 class="bg-gradient-to-r from-cyan-500 to-emerald-500 bg-clip-text text-4xl font-extrabold tracking-[-0.05em] text-transparent">
                Build faster.
            </h3>
            """,
            Code = """
            <h3 class="bg-gradient-to-r from-cyan-500 to-emerald-500 bg-clip-text text-4xl font-extrabold tracking-[-0.05em] text-transparent">
                Build faster.
            </h3>
            """
        },

        new Recipe
        {
            Id = 19,
            Name = "Soft Shadow",
            Category = "Shadows",
            Description = "Subtle neutral shadow for clean cards.",
            Accent = "slate",
            Preview = """
            <div class="rounded-2xl border border-slate-100 bg-white p-8 shadow-xl shadow-slate-200/60">
                <div class="text-lg font-extrabold">
                    Soft Shadow
                </div>
                <p class="mt-2 text-sm text-slate-500">
                    Lightweight elevation.
                </p>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-100 bg-white p-8 shadow-xl shadow-slate-200/60">
                Content
            </div>
            """
        },

        new Recipe
        {
            Id = 20,
            Name = "Cyan Glow",
            Category = "Shadows",
            Description = "Colored cyan glow for accent elements.",
            Accent = "cyan",
            Preview = """
            <button class="rounded-xl bg-cyan-400 px-6 py-3 text-sm font-bold text-slate-950 shadow-[0_18px_45px_-15px_rgba(34,211,238,0.9)]">
                Deploy
            </button>
            """,
            Code = """
            <button class="rounded-xl bg-cyan-400 px-6 py-3 text-sm font-bold text-slate-950 shadow-[0_18px_45px_-15px_rgba(34,211,238,0.9)]">
                Deploy
            </button>
            """
        },

        new Recipe
        {
            Id = 21,
            Name = "Auto Fit Grid",
            Category = "Grids",
            Description = "Responsive grid without media-query columns.",
            Accent = "cyan",
            Preview = """
            <div class="grid grid-cols-[repeat(auto-fit,minmax(90px,1fr))] gap-3">
                <div class="rounded-xl bg-cyan-100 p-5 text-center text-xs font-bold text-cyan-700">01</div>
                <div class="rounded-xl bg-cyan-100 p-5 text-center text-xs font-bold text-cyan-700">02</div>
                <div class="rounded-xl bg-cyan-100 p-5 text-center text-xs font-bold text-cyan-700">03</div>
                <div class="rounded-xl bg-cyan-100 p-5 text-center text-xs font-bold text-cyan-700">04</div>
            </div>
            """,
            Code = """
            <div class="grid grid-cols-[repeat(auto-fit,minmax(160px,1fr))] gap-4">
                <div>Item</div>
                <div>Item</div>
                <div>Item</div>
                <div>Item</div>
            </div>
            """
        },

        new Recipe
        {
            Id = 22,
            Name = "Responsive Grid",
            Category = "Grids",
            Description = "Standard responsive Tailwind card grid.",
            Accent = "emerald",
            Preview = """
            <div class="grid grid-cols-2 gap-3">
                <div class="rounded-xl bg-emerald-100 p-6"></div>
                <div class="rounded-xl bg-emerald-100 p-6"></div>
                <div class="rounded-xl bg-emerald-100 p-6"></div>
                <div class="rounded-xl bg-emerald-100 p-6"></div>
            </div>
            """,
            Code = """
            <div class="grid grid-cols-1 gap-4 sm:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4">
                <div>Card</div>
                <div>Card</div>
                <div>Card</div>
                <div>Card</div>
            </div>
            """
        },

        new Recipe
        {
            Id = 23,
            Name = "Line Clamp",
            Category = "Typography",
            Description = "Limit long text to two lines.",
            Accent = "cyan",
            Preview = """
            <div class="max-w-sm">
                <h3 class="text-lg font-extrabold text-slate-950">
                    Article title
                </h3>
                <p class="mt-2 line-clamp-2 text-sm leading-6 text-slate-500">
                    This is a longer paragraph that automatically gets clamped after two lines so your cards keep a consistent height even when content lengths are different.
                </p>
            </div>
            """,
            Code = """
            <p class="line-clamp-2 text-sm leading-6 text-slate-500">
                Long text content goes here.
            </p>
            """
        },

        new Recipe
        {
            Id = 24,
            Name = "Skeleton Loader",
            Category = "Loading",
            Description = "Simple animated skeleton loading state.",
            Accent = "slate",
            Preview = """
            <div class="w-full animate-pulse space-y-4">
                <div class="h-5 w-2/3 rounded-lg bg-slate-200"></div>
                <div class="h-3 w-full rounded-lg bg-slate-200"></div>
                <div class="h-3 w-5/6 rounded-lg bg-slate-200"></div>
                <div class="h-20 w-full rounded-xl bg-slate-200"></div>
            </div>
            """,
            Code = """
            <div class="animate-pulse space-y-4">
                <div class="h-5 w-2/3 rounded-lg bg-slate-200"></div>
                <div class="h-3 w-full rounded-lg bg-slate-200"></div>
                <div class="h-3 w-5/6 rounded-lg bg-slate-200"></div>
                <div class="h-20 w-full rounded-xl bg-slate-200"></div>
            </div>
            """
        },

        new Recipe
        {
            Id = 25,
            Name = "Spinner",
            Category = "Loading",
            Description = "Minimal Tailwind loading spinner.",
            Accent = "cyan",
            Preview = """
            <div class="size-10 animate-spin rounded-full border-4 border-slate-200 border-t-cyan-400"></div>
            """,
            Code = """
            <div class="size-10 animate-spin rounded-full border-4 border-slate-200 border-t-cyan-400"></div>
            """
        },

        new Recipe
        {
            Id = 26,
            Name = "Success Alert",
            Category = "Alerts",
            Description = "Compact emerald success notification.",
            Accent = "emerald",
            Preview = """
            <div class="rounded-xl border border-emerald-200 bg-emerald-50 p-4">
                <div class="font-bold text-emerald-800">
                    Changes saved
                </div>
                <p class="mt-1 text-sm text-emerald-700">
                    Your project has been updated successfully.
                </p>
            </div>
            """,
            Code = """
            <div class="rounded-xl border border-emerald-200 bg-emerald-50 p-4">
                <div class="font-bold text-emerald-800">
                    Changes saved
                </div>
                <p class="mt-1 text-sm text-emerald-700">
                    Your project has been updated successfully.
                </p>
            </div>
            """
        },

        new Recipe
        {
            Id = 27,
            Name = "Progress Bar",
            Category = "Progress",
            Description = "Clean progress indicator with percentage.",
            Accent = "cyan",
            Preview = """
            <div class="w-full">
                <div class="mb-2 flex items-center justify-between text-xs font-bold text-slate-600">
                    <span>Progress</span>
                    <span>72%</span>
                </div>
                <div class="h-2 overflow-hidden rounded-full bg-slate-200">
                    <div class="h-full w-[72%] rounded-full bg-cyan-400"></div>
                </div>
            </div>
            """,
            Code = """
            <div class="w-full">
                <div class="mb-2 flex items-center justify-between text-xs font-bold text-slate-600">
                    <span>Progress</span>
                    <span>72%</span>
                </div>
                <div class="h-2 overflow-hidden rounded-full bg-slate-200">
                    <div class="h-full w-[72%] rounded-full bg-cyan-400"></div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 28,
            Name = "Toggle Switch",
            Category = "Utilities",
            Description = "Simple visual toggle switch pattern.",
            Accent = "emerald",
            Preview = """
            <label class="inline-flex cursor-pointer items-center gap-3">
                <input type="checkbox" class="peer sr-only">
                <span class="relative h-6 w-11 rounded-full bg-slate-300 transition peer-checked:bg-emerald-400 after:absolute after:left-1 after:top-1 after:size-4 after:rounded-full after:bg-white after:transition after:content-[''] peer-checked:after:translate-x-5"></span>
                <span class="text-sm font-semibold text-slate-700">
                    Notifications
                </span>
            </label>
            """,
            Code = """
            <label class="inline-flex cursor-pointer items-center gap-3">
                <input type="checkbox" class="peer sr-only">
                <span class="relative h-6 w-11 rounded-full bg-slate-300 transition peer-checked:bg-emerald-400 after:absolute after:left-1 after:top-1 after:size-4 after:rounded-full after:bg-white after:transition after:content-[''] peer-checked:after:translate-x-5"></span>
                <span class="text-sm font-semibold text-slate-700">
                    Notifications
                </span>
            </label>
            """
        }
    ];
}