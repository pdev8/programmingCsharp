using System;

namespace CSP.SOLID
{
    public class SegregationPrinciple
    {
        public class Document { }

        public interface IPrinter
        {
            void Print(Document d);
        }

        public interface IScanner
        {
            void Scan(Document d);
        }

        public class PhotoCopier : IPrinter, IScanner
        {
            public void Print(Document d)
            {
                throw new NotImplementedException();
            }

            public void Scan(Document d)
            {
                throw new NotImplementedException();
            }
        }

        public interface IMultiFunctionDevice : IPrinter, IScanner
        {

        }

        public class MultiFunctionDevice : IMultiFunctionDevice
        {
            public void Print(Document d)
            {
                throw new NotImplementedException();
            }

            public void Scan(Document d)
            {
                throw new NotImplementedException();
            }
        }

        // Decorator pattern - delegating the calls to the calls of the inner printer and scanner variables
        public class MultiFunctionMachine
        {
            private IPrinter printer;
            private IScanner scanner;

            public MultiFunctionMachine(IPrinter printer, IScanner scanner)
            {
                this.printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
                this.scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
            }

            public void Print(Document d)
            {
                printer.Print(d);
            }

            public void Scan(Document d)
            {
                scanner.Scan(d);
            }
        }
    }
}