public static class EcommerceRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 141,
            Name = "Product Card",
            Category = "Ecommerce",
            Description = "Clean ecommerce product card with price and action.",
            Accent = "cyan",
            Preview = """
            <div class="w-full overflow-hidden rounded-2xl border border-slate-200 bg-white">
                <div class="flex h-36 items-center justify-center bg-gradient-to-br from-cyan-100 to-emerald-100">
                    <div class="size-20 rounded-2xl bg-white/70 shadow-lg backdrop-blur"></div>
                </div>

                <div class="p-5">
                    <div class="text-sm font-extrabold text-slate-950">
                        Studio Headphones
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        Wireless audio
                    </div>

                    <div class="mt-5 flex items-center justify-between">
                        <span class="text-lg font-extrabold text-slate-950">
                            €129
                        </span>

                        <button class="rounded-xl bg-cyan-400 px-4 py-2 text-xs font-bold text-slate-950">
                            Add
                        </button>
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="overflow-hidden rounded-2xl border border-slate-200 bg-white">
                <div class="aspect-[4/3] bg-slate-100">
                    <img
                        src="/product.jpg"
                        alt=""
                        class="h-full w-full object-cover"
                    >
                </div>

                <div class="p-5">
                    <div class="text-sm font-extrabold text-slate-950">
                        Studio Headphones
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        Wireless audio
                    </div>

                    <div class="mt-5 flex items-center justify-between">
                        <span class="text-lg font-extrabold text-slate-950">
                            €129
                        </span>

                        <button class="rounded-xl bg-cyan-400 px-4 py-2 text-xs font-bold text-slate-950">
                            Add
                        </button>
                    </div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 142,
            Name = "Product Price",
            Category = "Ecommerce",
            Description = "Price block with sale and old price styling.",
            Accent = "emerald",
            Preview = """
            <div class="flex items-end gap-3">
                <span class="text-4xl font-extrabold tracking-tight text-slate-950">
                    €79
                </span>

                <span class="pb-1 text-sm font-semibold text-slate-400 line-through">
                    €119
                </span>

                <span class="mb-1 rounded-full bg-emerald-100 px-2.5 py-1 text-[10px] font-bold text-emerald-700">
                    -34%
                </span>
            </div>
            """,
            Code = """
            <div class="flex items-end gap-3">
                <span class="text-4xl font-extrabold tracking-tight text-slate-950">
                    €79
                </span>

                <span class="pb-1 text-sm font-semibold text-slate-400 line-through">
                    €119
                </span>

                <span class="mb-1 rounded-full bg-emerald-100 px-2.5 py-1 text-[10px] font-bold text-emerald-700">
                    -34%
                </span>
            </div>
            """
        },

        new Recipe
        {
            Id = 143,
            Name = "Cart Item",
            Category = "Ecommerce",
            Description = "Compact shopping cart product row.",
            Accent = "cyan",
            Preview = """
            <div class="flex w-full items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <div class="size-16 shrink-0 rounded-xl bg-gradient-to-br from-cyan-100 to-emerald-100"></div>

                <div class="min-w-0 flex-1">
                    <div class="truncate text-sm font-extrabold text-slate-950">
                        Wireless Keyboard
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        Quantity: 1
                    </div>
                </div>

                <div class="text-sm font-extrabold text-slate-950">
                    €89
                </div>
            </div>
            """,
            Code = """
            <div class="flex items-center gap-4 rounded-2xl border border-slate-200 bg-white p-4">
                <img
                    src="/product.jpg"
                    alt=""
                    class="size-16 shrink-0 rounded-xl object-cover"
                >

                <div class="min-w-0 flex-1">
                    <div class="truncate text-sm font-extrabold text-slate-950">
                        Wireless Keyboard
                    </div>

                    <div class="mt-1 text-xs text-slate-400">
                        Quantity: 1
                    </div>
                </div>

                <div class="text-sm font-extrabold text-slate-950">
                    €89
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 144,
            Name = "Quantity Control",
            Category = "Ecommerce",
            Description = "Compact quantity selector for product pages.",
            Accent = "cyan",
            Preview = """
            <div class="inline-flex items-center overflow-hidden rounded-xl border border-slate-200 bg-white">
                <button class="flex size-10 items-center justify-center text-lg font-bold text-slate-500 hover:bg-slate-50">
                    −
                </button>

                <div class="flex size-10 items-center justify-center border-x border-slate-200 text-sm font-bold text-slate-950">
                    2
                </div>

                <button class="flex size-10 items-center justify-center text-lg font-bold text-cyan-600 hover:bg-cyan-50">
                    +
                </button>
            </div>
            """,
            Code = """
            <div class="inline-flex items-center overflow-hidden rounded-xl border border-slate-200 bg-white">
                <button class="flex size-10 items-center justify-center text-lg font-bold text-slate-500 hover:bg-slate-50">
                    −
                </button>

                <div class="flex size-10 items-center justify-center border-x border-slate-200 text-sm font-bold text-slate-950">
                    2
                </div>

                <button class="flex size-10 items-center justify-center text-lg font-bold text-cyan-600 hover:bg-cyan-50">
                    +
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 145,
            Name = "Checkout Summary",
            Category = "Ecommerce",
            Description = "Simple checkout summary with total and action button.",
            Accent = "emerald",
            Preview = """
            <div class="w-full rounded-2xl border border-slate-200 bg-white p-6">
                <div class="text-lg font-extrabold text-slate-950">
                    Order summary
                </div>

                <div class="mt-6 space-y-3 text-sm">
                    <div class="flex justify-between text-slate-500">
                        <span>Subtotal</span>
                        <span>€168</span>
                    </div>

                    <div class="flex justify-between text-slate-500">
                        <span>Shipping</span>
                        <span>€5</span>
                    </div>
                </div>

                <div class="my-5 border-t border-slate-200"></div>

                <div class="flex justify-between text-base font-extrabold text-slate-950">
                    <span>Total</span>
                    <span>€173</span>
                </div>

                <button class="mt-6 w-full rounded-xl bg-emerald-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Checkout
                </button>
            </div>
            """,
            Code = """
            <div class="rounded-2xl border border-slate-200 bg-white p-6">
                <div class="text-lg font-extrabold text-slate-950">
                    Order summary
                </div>

                <div class="mt-6 space-y-3 text-sm">
                    <div class="flex justify-between text-slate-500">
                        <span>Subtotal</span>
                        <span>€168</span>
                    </div>

                    <div class="flex justify-between text-slate-500">
                        <span>Shipping</span>
                        <span>€5</span>
                    </div>
                </div>

                <div class="my-5 border-t border-slate-200"></div>

                <div class="flex justify-between text-base font-extrabold text-slate-950">
                    <span>Total</span>
                    <span>€173</span>
                </div>

                <button class="mt-6 w-full rounded-xl bg-emerald-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Checkout
                </button>
            </div>
            """
        }
    ];
}