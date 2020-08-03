using System;
using Wasmtime;

namespace WasmtimeTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            using var engine = new Engine();
            using var module = Module.FromFile(engine, "fibonacci.wasm");

            using var host = new Host(engine);
            using dynamic instance = host.Instantiate(module);

            Console.WriteLine($"fib(12) = {instance.fib(12)}");
        }
    }
}
