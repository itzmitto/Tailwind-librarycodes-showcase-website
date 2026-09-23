public static class CyberRecipeData
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
    [
        new Recipe
        {
            Id = 112,
            Name = "Cyber Terminal Card",
            Category = "Cyberpunk",
            Description = "Dark terminal card with cyan system styling.",
            Accent = "cyan",
            Preview = """
            <div class="rounded-2xl bg-[#020617] p-6">
                <div class="rounded-xl border border-cyan-400/30 bg-cyan-400/5 p-5 shadow-[0_0_30px_rgba(34,211,238,0.12)]">
                    <div class="font-mono text-[10px] uppercase tracking-[0.2em] text-cyan-400">
                        SYSTEM_01
                    </div>
                    <div class="mt-6 font-mono text-lg font-bold text-white">
                        Connection stable
                    </div>
                    <div class="mt-2 font-mono text-xs text-emerald-400">
                        STATUS: ONLINE
                    </div>
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-xl border border-cyan-400/30 bg-cyan-400/5 p-5 shadow-[0_0_30px_rgba(34,211,238,0.12)]">
                <div class="font-mono text-[10px] uppercase tracking-[0.2em] text-cyan-400">
                    SYSTEM_01
                </div>
                <div class="mt-6 font-mono text-lg font-bold text-white">
                    Connection stable
                </div>
                <div class="mt-2 font-mono text-xs text-emerald-400">
                    STATUS: ONLINE
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 113,
            Name = "Cyber Action Button",
            Category = "Cyberpunk",
            Description = "Angular cyan action button for futuristic interfaces.",
            Accent = "cyan",
            Preview = """
            <div class="flex justify-center rounded-2xl bg-slate-950 p-10">
                <button class="border border-cyan-400 bg-cyan-400/10 px-7 py-3 font-mono text-xs font-bold uppercase tracking-[0.16em] text-cyan-300 shadow-[4px_4px_0_rgb(34_211_238)] transition hover:translate-x-1 hover:translate-y-1 hover:shadow-none">
                    Execute
                </button>
            </div>
            """,
            Code = """
            <button class="border border-cyan-400 bg-cyan-400/10 px-7 py-3 font-mono text-xs font-bold uppercase tracking-[0.16em] text-cyan-300 shadow-[4px_4px_0_rgb(34_211_238)] transition hover:translate-x-1 hover:translate-y-1 hover:shadow-none">
                Execute
            </button>
            """
        },

        new Recipe
        {
            Id = 114,
            Name = "Cyber Input",
            Category = "Cyberpunk",
            Description = "Terminal-inspired input with status indicator.",
            Accent = "emerald",
            Preview = """
            <div class="rounded-2xl bg-slate-950 p-8">
                <div class="flex overflow-hidden border border-emerald-400/40 bg-black/30">
                    <span class="flex items-center border-r border-emerald-400/30 px-4 font-mono text-xs text-emerald-400">
                        &gt;
                    </span>
                    <input
                        type="text"
                        placeholder="enter_command"
                        class="min-w-0 flex-1 bg-transparent px-4 py-3 font-mono text-sm text-emerald-300 outline-none placeholder:text-emerald-900"
                    >
                </div>
            </div>
            """,
            Code = """
            <div class="flex overflow-hidden border border-emerald-400/40 bg-black/30">
                <span class="flex items-center border-r border-emerald-400/30 px-4 font-mono text-xs text-emerald-400">
                    &gt;
                </span>
                <input
                    type="text"
                    placeholder="enter_command"
                    class="min-w-0 flex-1 bg-transparent px-4 py-3 font-mono text-sm text-emerald-300 outline-none placeholder:text-emerald-900"
                >
            </div>
            """
        },

        new Recipe
        {
            Id = 115,
            Name = "Cyber Stat Grid",
            Category = "Cyberpunk",
            Description = "Cyber dashboard statistics with glowing data values.",
            Accent = "cyan",
            Preview = """
            <div class="grid w-full grid-cols-2 gap-3 rounded-2xl bg-slate-950 p-5">
                <div class="border border-cyan-400/20 bg-cyan-400/5 p-4">
                    <div class="font-mono text-[9px] uppercase tracking-widest text-slate-500">CPU</div>
                    <div class="mt-2 font-mono text-2xl font-bold text-cyan-300">42%</div>
                </div>
                <div class="border border-emerald-400/20 bg-emerald-400/5 p-4">
                    <div class="font-mono text-[9px] uppercase tracking-widest text-slate-500">RAM</div>
                    <div class="mt-2 font-mono text-2xl font-bold text-emerald-300">68%</div>
                </div>
            </div>
            """,
            Code = """
            <div class="grid grid-cols-2 gap-3 bg-slate-950 p-5">
                <div class="border border-cyan-400/20 bg-cyan-400/5 p-4">
                    <div class="font-mono text-[9px] uppercase tracking-widest text-slate-500">
                        CPU
                    </div>
                    <div class="mt-2 font-mono text-2xl font-bold text-cyan-300">
                        42%
                    </div>
                </div>

                <div class="border border-emerald-400/20 bg-emerald-400/5 p-4">
                    <div class="font-mono text-[9px] uppercase tracking-widest text-slate-500">
                        RAM
                    </div>
                    <div class="mt-2 font-mono text-2xl font-bold text-emerald-300">
                        68%
                    </div>
                </div>
            </div>
            """
        },

        new Recipe
        {
            Id = 116,
            Name = "Cyber Status",
            Category = "Cyberpunk",
            Description = "Compact cyber status indicator with pulse.",
            Accent = "emerald",
            Preview = """
            <div class="inline-flex items-center gap-3 rounded-lg border border-emerald-400/30 bg-slate-950 px-4 py-3">
                <span class="relative flex size-3">
                    <span class="absolute inline-flex size-full animate-ping rounded-full bg-emerald-400 opacity-60"></span>
                    <span class="relative inline-flex size-3 rounded-full bg-emerald-400"></span>
                </span>
                <span class="font-mono text-xs font-bold uppercase tracking-widest text-emerald-300">
                    Online
                </span>
            </div>
            """,
            Code = """
            <div class="inline-flex items-center gap-3 rounded-lg border border-emerald-400/30 bg-slate-950 px-4 py-3">
                <span class="relative flex size-3">
                    <span class="absolute inline-flex size-full animate-ping rounded-full bg-emerald-400 opacity-60"></span>
                    <span class="relative inline-flex size-3 rounded-full bg-emerald-400"></span>
                </span>

                <span class="font-mono text-xs font-bold uppercase tracking-widest text-emerald-300">
                    Online
                </span>
            </div>
            """
        },

        new Recipe
        {
            Id = 117,
            Name = "Cyber Warning",
            Category = "Cyberpunk",
            Description = "Futuristic warning panel with amber accents.",
            Accent = "amber",
            Preview = """
            <div class="rounded-xl border-l-4 border-amber-400 bg-slate-950 p-5 shadow-[0_0_25px_rgba(251,191,36,0.12)]">
                <div class="font-mono text-[10px] uppercase tracking-[0.18em] text-amber-400">
                    Warning
                </div>
                <div class="mt-3 font-mono text-sm font-bold text-white">
                    Resource threshold reached
                </div>
            </div>
            """,
            Code = """
            <div class="rounded-xl border-l-4 border-amber-400 bg-slate-950 p-5 shadow-[0_0_25px_rgba(251,191,36,0.12)]">
                <div class="font-mono text-[10px] uppercase tracking-[0.18em] text-amber-400">
                    Warning
                </div>
                <div class="mt-3 font-mono text-sm font-bold text-white">
                    Resource threshold reached
                </div>
            </div>
            """
        }
    ];
}