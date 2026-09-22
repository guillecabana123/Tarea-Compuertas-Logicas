classDiagram
    class ILogicComponent {
        <<interface>>
        +Evaluate() bool
    }
    class Value {
        -value bool
        +Evaluate() bool
    }
    class Gate {
        <<abstract>>
        +Evaluate() bool*
    }
    class AndGate {
        +Evaluate() bool
    }
    class OrGate {
        +Evaluate() bool
    }
    class NotGate {
        +Evaluate() bool
    }
    ILogicComponent <|.. Value
    ILogicComponent <|.. Gate
    Gate <|-- AndGate
    Gate <|-- OrGate
    Gate <|-- NotGate