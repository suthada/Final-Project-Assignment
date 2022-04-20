# Final-Project-Assignment

###ความเป็นมาของโปรแกรม
โปรมแกรมที่สร้างขึ้นมาคือ โปรแกรมคำนวณภาษี เพราะที่บ้านทำเกี่ยวกับบ้านเช่าแล้วต้องจ่ายภาษีทุกปีอยู่แล้ว 

<br/><br/>
###วัตถุประสงค์ของโปรแกรม
เพื่อคำนวณภาษีที่ต้องเสียให้กับทางรัฐบาลในทุกๆปี

<br/><br/>
###โครงสร้างของโปรแกรม (Class diagram)
classDiagram
    Program <|-- Tax
    Tax <|-- Live
    Tax <|-- Trade
    Tax <|-- Empty
    Program : +Main()
    class Tax{
        +FileToolStripMenuItem_Click()
        +OpenToolStripMenuItem_Click()
        +SaveToolStripMenuItem_Click()
        +buttonSave_Click()
        +buttonDelete_Click()
    }
    class Live{
        +live()
        +assess()
    }
    class Trade{
        +live()
        +assess()
    }
    class Empty{
        +live()
        +assess()
    }
    
<br/><br/>
###ชื่อของผู้พัฒนาโปรแกรม
643450089-0 นางสาวสุธาดา โสภาพ
