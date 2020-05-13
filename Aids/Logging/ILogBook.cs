using System;

namespace Loppprojekt.Aids.Logging {

    public interface ILogBook {
        void WriteEntry(string message);

        void WriteEntry(Exception e);
    }

}


