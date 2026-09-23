public static class AuthRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 181,
            Name = "Clean Login",
            Category = "Auth",
            Description = "Clean login form with email, password and primary action.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-3xl border border-slate-200 bg-white p-7 shadow-lg shadow-slate-200/50">
                <div class="text-2xl font-extrabold tracking-tight text-slate-950">
                    Welcome back
                </div>

                <p class="mt-2 text-sm text-slate-500">
                    Sign in to continue.
                </p>

                <div class="mt-6 space-y-3">
                    <input
                        type="email"
                        placeholder="Email address"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                    >

                    <input
                        type="password"
                        placeholder="Password"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                    >
                </div>

                <button class="mt-5 w-full rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Sign in
                </button>
            </div>
            """,
            Code = """
            <form class="rounded-3xl border border-slate-200 bg-white p-7 shadow-lg shadow-slate-200/50">
                <div class="text-2xl font-extrabold tracking-tight text-slate-950">
                    Welcome back
                </div>

                <p class="mt-2 text-sm text-slate-500">
                    Sign in to continue.
                </p>

                <div class="mt-6 space-y-3">
                    <input
                        type="email"
                        placeholder="Email address"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                    >

                    <input
                        type="password"
                        placeholder="Password"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                    >
                </div>

                <button class="mt-5 w-full rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Sign in
                </button>
            </form>
            """
        },

        new Recipe
        {
            Id = 182,
            Name = "Dark Login",
            Category = "Auth",
            Description = "Dark authentication panel with neon cyan accents.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-3xl bg-slate-950 p-7">
                <div class="text-2xl font-extrabold text-white">
                    Account access
                </div>

                <p class="mt-2 text-sm text-slate-500">
                    Enter your credentials.
                </p>

                <div class="mt-6 space-y-3">
                    <input
                        type="email"
                        placeholder="Email"
                        class="w-full rounded-xl border border-white/10 bg-white/5 px-4 py-3 text-sm text-white outline-none placeholder:text-slate-600 focus:border-cyan-400/60 focus:ring-4 focus:ring-cyan-400/10"
                    >

                    <input
                        type="password"
                        placeholder="Password"
                        class="w-full rounded-xl border border-white/10 bg-white/5 px-4 py-3 text-sm text-white outline-none placeholder:text-slate-600 focus:border-cyan-400/60 focus:ring-4 focus:ring-cyan-400/10"
                    >
                </div>

                <button class="mt-5 w-full rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950 shadow-[0_0_25px_rgba(34,211,238,0.25)]">
                    Login
                </button>
            </div>
            """,
            Code = """
            <form class="rounded-3xl bg-slate-950 p-7">
                <div class="text-2xl font-extrabold text-white">
                    Account access
                </div>

                <p class="mt-2 text-sm text-slate-500">
                    Enter your credentials.
                </p>

                <div class="mt-6 space-y-3">
                    <input
                        type="email"
                        placeholder="Email"
                        class="w-full rounded-xl border border-white/10 bg-white/5 px-4 py-3 text-sm text-white outline-none placeholder:text-slate-600 focus:border-cyan-400/60 focus:ring-4 focus:ring-cyan-400/10"
                    >

                    <input
                        type="password"
                        placeholder="Password"
                        class="w-full rounded-xl border border-white/10 bg-white/5 px-4 py-3 text-sm text-white outline-none placeholder:text-slate-600 focus:border-cyan-400/60 focus:ring-4 focus:ring-cyan-400/10"
                    >
                </div>

                <button class="mt-5 w-full rounded-xl bg-cyan-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Login
                </button>
            </form>
            """
        },

        new Recipe
        {
            Id = 183,
            Name = "Register Form",
            Category = "Auth",
            Description = "Compact account creation form.",
            Accent = "emerald",
            Preview = """
            <div class="w-full rounded-3xl border border-slate-200 bg-white p-7">
                <div class="text-2xl font-extrabold text-slate-950">
                    Create account
                </div>

                <div class="mt-6 space-y-3">
                    <input
                        type="text"
                        placeholder="Full name"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                    >

                    <input
                        type="email"
                        placeholder="Email"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                    >

                    <input
                        type="password"
                        placeholder="Password"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                    >
                </div>

                <button class="mt-5 w-full rounded-xl bg-emerald-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Create account
                </button>
            </div>
            """,
            Code = """
            <form class="rounded-3xl border border-slate-200 bg-white p-7">
                <div class="text-2xl font-extrabold text-slate-950">
                    Create account
                </div>

                <div class="mt-6 space-y-3">
                    <input
                        type="text"
                        placeholder="Full name"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                    >

                    <input
                        type="email"
                        placeholder="Email"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                    >

                    <input
                        type="password"
                        placeholder="Password"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                    >
                </div>

                <button class="mt-5 w-full rounded-xl bg-emerald-400 px-5 py-3 text-sm font-bold text-slate-950">
                    Create account
                </button>
            </form>
            """
        },

        new Recipe
        {
            Id = 184,
            Name = "OTP Input",
            Category = "Auth",
            Description = "Six digit verification input layout.",
            Accent = "cyan",
            Preview = """
            <div class="w-full text-center">
                <div class="text-lg font-extrabold text-slate-950">
                    Verification code
                </div>

                <p class="mt-2 text-xs text-slate-400">
                    Enter the six digit code.
                </p>

                <div class="mt-6 flex justify-center gap-2">
                    <input maxlength="1" value="4" class="size-11 rounded-xl border border-cyan-400 bg-cyan-50 text-center font-bold outline-none">
                    <input maxlength="1" value="8" class="size-11 rounded-xl border border-cyan-400 bg-cyan-50 text-center font-bold outline-none">
                    <input maxlength="1" class="size-11 rounded-xl border border-slate-300 text-center font-bold outline-none">
                    <input maxlength="1" class="size-11 rounded-xl border border-slate-300 text-center font-bold outline-none">
                    <input maxlength="1" class="size-11 rounded-xl border border-slate-300 text-center font-bold outline-none">
                    <input maxlength="1" class="size-11 rounded-xl border border-slate-300 text-center font-bold outline-none">
                </div>
            </div>
            """,
            Code = """
            <div class="flex justify-center gap-2">
                <input maxlength="1" class="size-11 rounded-xl border border-slate-300 text-center font-bold outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100">
                <input maxlength="1" class="size-11 rounded-xl border border-slate-300 text-center font-bold outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100">
                <input maxlength="1" class="size-11 rounded-xl border border-slate-300 text-center font-bold outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100">
                <input maxlength="1" class="size-11 rounded-xl border border-slate-300 text-center font-bold outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100">
                <input maxlength="1" class="size-11 rounded-xl border border-slate-300 text-center font-bold outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100">
                <input maxlength="1" class="size-11 rounded-xl border border-slate-300 text-center font-bold outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100">
            </div>
            """
        },

        new Recipe
        {
            Id = 185,
            Name = "Forgot Password",
            Category = "Auth",
            Description = "Password recovery form with simple focused layout.",
            Accent = "cyan",
            Preview = """
            <div class="w-full rounded-3xl border border-slate-200 bg-white p-7">
                <div class="flex size-12 items-center justify-center rounded-2xl bg-cyan-100 font-bold text-cyan-700">
                    ↻
                </div>

                <div class="mt-5 text-xl font-extrabold text-slate-950">
                    Reset password
                </div>

                <p class="mt-2 text-sm leading-6 text-slate-500">
                    Enter your email and receive a recovery link.
                </p>

                <input
                    type="email"
                    placeholder="Email address"
                    class="mt-5 w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >

                <button class="mt-3 w-full rounded-xl bg-slate-950 px-5 py-3 text-sm font-bold text-white">
                    Send recovery link
                </button>
            </div>
            """,
            Code = """
            <form class="rounded-3xl border border-slate-200 bg-white p-7">
                <div class="flex size-12 items-center justify-center rounded-2xl bg-cyan-100 font-bold text-cyan-700">
                    ↻
                </div>

                <div class="mt-5 text-xl font-extrabold text-slate-950">
                    Reset password
                </div>

                <p class="mt-2 text-sm leading-6 text-slate-500">
                    Enter your email and receive a recovery link.
                </p>

                <input
                    type="email"
                    placeholder="Email address"
                    class="mt-5 w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none focus:border-cyan-400 focus:ring-4 focus:ring-cyan-100"
                >

                <button class="mt-3 w-full rounded-xl bg-slate-950 px-5 py-3 text-sm font-bold text-white">
                    Send recovery link
                </button>
            </form>
            """
        }
    ];
}