using System;

namespace InterfaceMsLearn;

public interface IPerson
{
    string Name { get; set; }
    int Age { get; set; }
    void DisplayInfo();
}
