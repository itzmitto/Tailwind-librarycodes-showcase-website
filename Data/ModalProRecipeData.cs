public static class ModalProRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 196,
            Name = "Confirmation Modal",
            Category = "Modals Pro",
            Description = "General confirmation dialog with primary and secondary actions.",
            Accent = "cyan",
            Preview = """
            <div class="w-full max-w-sm rounded-3xl border border-slate-200 bg-white p-6 shadow-2xl">
                <div class="flex size-12 items-center justify-center rounded-2xl bg-cyan-100 font-bold text-cyan-700">
                    ?
                </div>

                <div class="mt-5 text-xl font-extrabold text-slate-950">
                    Confirm action
                </div>

                <p class="mt-2 text-sm leading-6 text-slate-500">
                    Are you sure you want to continue?
                </p>

                <div class="mt-6 flex justify-end gap-2">
                    <button class="rounded-xl border border-slate-200 px-4 py-2.5 text-xs font-bold text-slate-600">
                        Cancel
                    </button>

                    <button class="rounded-xl bg-cyan-400 px-4 py-2.5 text-xs font-bold text-slate-950">
                        Continue
                    </button>
                </div>
            </div>
            """,
            Code = """
            <div class="w-full max-w-sm rounded-3xl border border-slate-200 bg-white p-6 shadow-2xl">
                <div class="flex size-12 items-center justify-center rounded-2xl bg-cyan-100 font-bold text-cyan-700">
                    ?
                </div>

                <div class="mt-5 text-xl font-extrabold text-slate-950">
                    Confirm action
                </div>

                <p class="mt-2 text-sm leading-6 text-slate-500">
                    Are you sure you want to continue?
                </p>

                <div class="mt-6 flex justify-end gap-2">
                    <button class="rounded-xl border border-slate-200 px-4 py-2.5 text-xs font-bold text-slate-600">
                        Cancel
                    </button>

                    <button class="rounded-xl bg-cyan-400 px-4 py-2.5 text-xs font-bold text-slate-950">
                        Continue
                    </button>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 197,
            Name = "Delete Modal",
            Category = "Modals Pro",
            Description = "Destructive confirmation modal for delete operations.",
            Accent = "rose",
            Preview = """
            <div class="w-full max-w-sm rounded-3xl border border-rose-100 bg-white p-6 shadow-2xl">
                <div class="flex size-12 items-center justify-center rounded-2xl bg-rose-100 font-bold text-rose-600">
                    !
                </div>

                <div class="mt-5 text-xl font-extrabold text-slate-950">
                    Delete project?
                </div>

                <p class="mt-2 text-sm leading-6 text-slate-500">
                    This action cannot be undone.
                </p>

                <button class="mt-6 w-full rounded-xl bg-rose-500 px-4 py-3 text-sm font-bold text-white">
                    Delete permanently
                </button>
            </div>
            """,
            Code = """
            <div class="w-full max-w-sm rounded-3xl border border-rose-100 bg-white p-6 shadow-2xl">
                <div class="flex size-12 items-center justify-center rounded-2xl bg-rose-100 font-bold text-rose-600">
                    !
                </div>

                <div class="mt-5 text-xl font-extrabold text-slate-950">
                    Delete project?
                </div>

                <p class="mt-2 text-sm leading-6 text-slate-500">
                    This action cannot be undone.
                </p>

                <button class="mt-6 w-full rounded-xl bg-rose-500 px-4 py-3 text-sm font-bold text-white">
                    Delete permanently
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 198,
            Name = "Glass Modal",
            Category = "Modals Pro",
            Description = "Glassmorphism dialog for colorful interfaces.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-3xl bg-gradient-to-br from-cyan-300 via-violet-300 to-emerald-300 p-7">
                <div class="w-full max-w-sm rounded-3xl border border-white/50 bg-white/30 p-6 shadow-2xl backdrop-blur-2xl">
                    <div class="text-xs font-bold uppercase tracking-widest text-slate-700">
                        Glass Dialog
                    </div>

                    <div class="mt-7 text-xl font-extrabold text-slate-950">
                        Save changes?
                    </div>

                    <p class="mt-2 text-sm text-slate-700">
                        Your configuration will be updated.
                    </p>
                </div>
            </div>
            """,
            Code = """
            <div class="w-full max-w-sm rounded-3xl border border-white/50 bg-white/30 p-6 shadow-2xl backdrop-blur-2xl">
                <div class="text-xs font-bold uppercase tracking-widest text-slate-700">
                    Glass Dialog
                </div>

                <div class="mt-7 text-xl font-extrabold text-slate-950">
                    Save changes?
                </div>

                <p class="mt-2 text-sm text-slate-700">
                    Your configuration will be updated.
                </p>
            </div>
            """
        },

        new Recipe
        {
            Id = 199,
            Name = "Dark Modal",
            Category = "Modals Pro",
            Description = "Dark modal panel with neon cyan highlight.",
            Accent = "cyan",
            Preview = """
            <div class="w-full max-w-sm rounded-3xl border border-cyan-400/20 bg-slate-950 p-6 shadow-[0_0_45px_rgba(34,211,238,0.15)]">
                <div class="text-xs font-bold uppercase tracking-[0.18em] text-cyan-400">
                    System dialog
                </div>

                <div class="mt-7 text-xl font-extrabold text-white">
                    Deployment ready
                </div>

                <p class="mt-2 text-sm text-slate-400">
                    Production can now be updated.
                </p>

                <button class="mt-6 w-full rounded-xl bg-cyan-400 px-4 py-3 text-sm font-bold text-slate-950">
                    Deploy
                </button>
            </div>
            """,
            Code = """
            <div class="w-full max-w-sm rounded-3xl border border-cyan-400/20 bg-slate-950 p-6 shadow-[0_0_45px_rgba(34,211,238,0.15)]">
                <div class="text-xs font-bold uppercase tracking-[0.18em] text-cyan-400">
                    System dialog
                </div>

                <div class="mt-7 text-xl font-extrabold text-white">
                    Deployment ready
                </div>

                <p class="mt-2 text-sm text-slate-400">
                    Production can now be updated.
                </p>

                <button class="mt-6 w-full rounded-xl bg-cyan-400 px-4 py-3 text-sm font-bold text-slate-950">
                    Deploy
                </button>
            </div>
            """
        },

        new Recipe
        {
            Id = 200,
            Name = "Form Modal",
            Category = "Modals Pro",
            Description = "Modal layout containing a compact form.",
            Accent = "emerald",
            Preview = """
            <div class="w-full max-w-md rounded-3xl border border-slate-200 bg-white p-6 shadow-2xl">
                <div class="text-xl font-extrabold text-slate-950">
                    Create project
                </div>

                <div class="mt-5 space-y-3">
                    <input
                        placeholder="Project name"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                    >

                    <textarea
                        rows="3"
                        placeholder="Description"
                        class="w-full resize-none rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                    ></textarea>
                </div>

                <div class="mt-5 flex justify-end gap-2">
                    <button class="rounded-xl border border-slate-200 px-4 py-2.5 text-xs font-bold text-slate-500">
                        Cancel
                    </button>

                    <button class="rounded-xl bg-emerald-400 px-4 py-2.5 text-xs font-bold text-slate-950">
                        Create
                    </button>
                </div>
            </div>
            """,
            Code = """
            <div class="w-full max-w-md rounded-3xl border border-slate-200 bg-white p-6 shadow-2xl">
                <div class="text-xl font-extrabold text-slate-950">
                    Create project
                </div>

                <div class="mt-5 space-y-3">
                    <input
                        placeholder="Project name"
                        class="w-full rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                    >

                    <textarea
                        rows="3"
                        placeholder="Description"
                        class="w-full resize-none rounded-xl border border-slate-300 px-4 py-3 text-sm outline-none"
                    ></textarea>
                </div>

                <div class="mt-5 flex justify-end gap-2">
                    <button class="rounded-xl border border-slate-200 px-4 py-2.5 text-xs font-bold text-slate-500">
                        Cancel
                    </button>

                    <button class="rounded-xl bg-emerald-400 px-4 py-2.5 text-xs font-bold text-slate-950">
                        Create
                    </button>
                </div>
            </div>
            """
        }
    ];
}