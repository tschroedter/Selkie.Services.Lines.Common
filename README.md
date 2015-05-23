# Selkie.Services.Lines.Common

The Selkie.Services.Lines.Common project creates a NuGet package. This package contains the common messages published and received by the service 'Selkie.Services.Lines':

* LineValidationRequestMessage
* LineValidationResponseMessage
* TestLineRequestMessage
* TestLineRequestMessage


# Messages

LineValidationRequestMessage
* The message is used to request a validation of an lines.
```CS
public class LineValidationRequestMessage
{
    [NotNull]
    public LineDto[] LineDtos = new LineDto[0];
}
```

LineValidationResponseMessage
* The message is the response to a LineValidationRequestMessage.
```CS
public class LineValidationResponseMessage
{
    public bool AreValid;

    [NotNull]
    public LineDto[] LineDtos = new LineDto[0];
}
```

TestLineRequestMessage
* The message is used to request a set of lines used for testing.
```CS
public class TestLineRequestMessage
{
    [NotNull]
    public TestLineType.Type[] Types = new TestLineType.Type[0];
}
```

TestLineRequestMessage
* The message is used to request a set of lines used for testing.
```CS
public class TestLineRequestMessage
{
    [NotNull]
    public TestLineType.Type[] Types = new TestLineType.Type[0];
}
```

TestLineResponseMessage
* The message is used to request a set of lines used for testing.
```CS
public class TestLineResponseMessage
{
    [NotNull]
    public LineDto[] LineDtos = new LineDto[0];
}
```

TestLineType
* List of available test lines.
```CS
public class TestLineType
{
    public enum Type
    {
        CreateLines,
        CreateFixedParallelLines,
        CreateParallelLines,
        CreateParallelLinesForwardReverse,
        CreateParallelLinesReverse,
        CreateBox,
        CreateCross,
        CreateCrossForwardReverse,
        CreateParallelCrossLinesInCorner,
        CreateParallelCrossLines,
        CreateParallelCrossLinesForwardReverse,
        CreateLinesInRowHorizontal,
        CreateRandomLines,
        Create45DegreeLines,
        CreateTestLines,
        CreateTestLinesVertical
    }
}
```

# Selkie
Selkie.Services.Lines.Common is part of the Selkie project which is based on Castle Windsor and EasyNetQ. The main goal of the Selkie project is to calculate and displays the shortest path for a boat travelling along survey lines from point A to B. The algorithm takes into account the minimum required turn circle of a vessel required to navigate from one line to another.

The project started as a little ant colony optimization application. Over time the application grew and was split up into different services which communicate via RabbitMQ. The whole project is used to try out TDD, BDD, DRY and SOLID.

### Selkie Projects

* [Selkie](https://github.com/tschroedter/Selkie)
* [Selkie.Aco](https://github.com/tschroedter/Selkie.Aco)
* [Selkie Common](https://github.com/tschroedter/Selkie.Common)
* [Selkie EasyNetQ](https://github.com/tschroedter/Selkie.EasyNetQ)
* [Selkie Geometry](https://github.com/tschroedter/Selkie.Geometry)
* [Selkie NUnit Extensions](https://github.com/tschroedter/Selkie.NUnit.Extensions)
* [Selkie Racetrack](https://github.com/tschroedter/Selkie.Racetrack)
* [Selkie Services ACO](https://github.com/tschroedter/Selkie.Services.Aco)
* [Selkie Services ACO Common](https://github.com/tschroedter/Selkie.Services.Aco.Common)
* [Selkie Services Common](https://github.com/tschroedter/Selkie.Services.Common)
* [Selkie Services Lines](https://github.com/tschroedter/Selkie.Services.Lines)
* [Selkie Services Lines Common](https://github.com/tschroedter/Selkie.Services.Lines.Common)
* [Selkie Services Monitor](https://github.com/tschroedter/Selkie.Services.Monitor)
* [Selkie Services Racetracks](https://github.com/tschroedter/Selkie.Services.Racetracks)
* [Selkie Services Racetracks Common](https://github.com/tschroedter/Selkie.Services.Racetracks.Common)
* Selkie Web
* [Selkie Windsor](https://github.com/tschroedter/Selkie.Windsor)
* Selkie WPF
* [Selkie XUnit Extensions](https://github.com/tschroedter/Selkie.XUnit.Extensions)
