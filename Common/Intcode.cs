using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public static class Intcode
    {
        public delegate int InputHandler();
        public delegate void OutputHandler(int value);
        public delegate void Logger(string message);

        public static int[] Run(string program, InputHandler input = null, OutputHandler output = null, Logger logger = null)
            => Intcode.Run(program.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(str => int.Parse(str)), input, output, logger);

        static int resolveParam(int paramIdx, int pctr, int[] memory)
        {
            var instr = memory[pctr];
            var mode = (instr / (int)Math.Pow(10, paramIdx + 2)) % 10;

            switch (mode)
            {
                case 0: return memory[memory[pctr + 1 + paramIdx]];         // Position mode
                case 1: return memory[pctr + 1 + paramIdx];                 // Immediate mode
                default: throw new Exception($"Unknown mode {mode}");
            }
        }

        public static int[] Run(IEnumerable<int> program, InputHandler input = null, OutputHandler output = null, Logger logger = null)
        {
            if (input == null) input = () => int.Parse(Console.ReadLine());
            if (output == null) output = (val) => Console.WriteLine(val);

            var memory = program.ToArray();

            var pctr = 0;
            bool running = true;

            while (running)
            {
                var instr = memory[pctr];

                void log(string message) => logger?.Invoke($"{instr}: {message}");

                switch (instr % 100)
                {
                    case 1:
                    {
                        var x1 = resolveParam(0, pctr, memory);
                        var x2 = resolveParam(1, pctr, memory);
                        var pout = memory[pctr + 3];

                        var result = x1 + x2;
                        memory[pout] = result;
                        pctr += 4;

                        log($"Set {pout} to {x1}+{x2}={result}");
                        break;
                    }

                    case 2:
                    {
                        var x1 = resolveParam(0, pctr, memory);
                        var x2 = resolveParam(1, pctr, memory);
                        var pout = memory[pctr + 3];

                        var result = x1 * x2;
                        memory[pout] = result;
                        pctr += 4;

                        log($"Set {pout} to {x1}*{x2}={result}");
                        break;
                    }

                    case 3:
                    {
                        var pout = memory[pctr + 1];
                        var val = input();
                        memory[pout] = val;
                        pctr += 2;

                        log($"Set {pout} to (input) {val}");
                        break;
                    }

                    case 4:
                    {
                        var x = resolveParam(0, pctr, memory);
                        output(x);
                        pctr += 2;

                        log($"Output {x}");
                        break;
                    }

                    case 5:
                    {
                        var x = resolveParam(0, pctr, memory);

                        if (x != 0)
                        {
                            pctr = resolveParam(1, pctr, memory);
                            log($"{x} != 0; jumping to {pctr}");
                        }
                        else
                        {
                            log($"{x} == 0; noop");
                            pctr += 3;
                        }

                        break;
                    }

                    case 6:
                    {
                        var x = resolveParam(0, pctr, memory);

                        if (x == 0)
                        {
                            pctr = resolveParam(1, pctr, memory);
                            log($"{x} == 0; jumping to {pctr}");
                        }
                        else
                        {
                            log($"{x} != 0; noop");
                            pctr += 3;
                        }

                        break;
                    }

                    case 7:
                    {
                        var x1 = resolveParam(0, pctr, memory);
                        var x2 = resolveParam(1, pctr, memory);
                        var pOut = memory[pctr + 3];

                        var result = (x1 < x2) ? 1 : 0;
                        memory[pOut] = result;

                        log($"Set {pOut} to {result} ({x1} < {x2}?)");

                        pctr += 4;
                        break;
                    }

                    case 8:
                    {
                        var x1 = resolveParam(0, pctr, memory);
                        var x2 = resolveParam(1, pctr, memory);
                        var pOut = memory[pctr + 3];

                        var result = (x1 == x2) ? 1 : 0;
                        memory[pOut] = result;

                        log($"Set {pOut} to {result} ({x1} = {x2}?)");

                        pctr += 4;
                        break;
                    }

                    case 99:
                    {
                        running = false;
                        log($"Stopping");
                        break;
                    }

                    default: throw new Exception($"Unknown instr {instr}");
                }

            }

            return memory;
        }
    }
}
