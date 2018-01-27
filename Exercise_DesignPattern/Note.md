# Design Pattern
### Design Pattern 分類

##### 進度 23/23

Creational pattern

> 在軟體工程中，是處理物件創建機制的設計模式。此類型模式試圖根據適合的情況來決定建立物件。單純的物件創建常會導致一些設計問題或增加設計的複雜度。創建型模式則藉由控制物件的生成方式來解決這問題。

> 處理「產生 object」。主要的目的有二，一是希望封裝 concrete class，二是想封裝「如何產生並結合 concrete class 的 instance」的過程。
>  
* Factory (抽象工廠) [done]
    * Simple Factory  (簡單工廠模式)
    * Abstract Factory  (抽象工廠模式)：為一個產品族提供了統一的創建介面。當需要這個產品族的某一系列的時候，可以從抽象工廠中選出相應的系列創建一個具體的工廠類。
     
    目的 : 使程式能輕易的 Port 到另外一個系統上。
    使用時機：為要建立一個容易 update , 可移植性高的系統時。
    > 對於資料的存取，我們希望實現多資料庫，不侷限於某一個資料庫。
    > 可衍伸出 SimplyFactory、Simple Abstract Factory 的改進    
* Builder (建造者模式) [done]
    > 將一個複雜對象的構建與它的表示分離，使得同樣的構建過程可以創建不同的表示。

    >目的 : Client 不斷呼叫 Builder 建立 component 直到建立完整的 complex component 才呼叫 Builder 傳回 complex component。
    
    >使用時機：**在設計多目標，多樣的彈性系統時，或目標樣式尚未決定時使用之**。

* Factory Method (工廠方法) [done]
  > 綠茶工廠生產綠茶，紅茶工廠生產紅茶
* Prototype (原型模式) [done]
  > 用原型實例指定創建對象的種類，並且通過拷貝這些原型創建新的對象。
  > 淺複製：複製所有欄位，參考型別只複製參考。
  > 深複製：建立新的物件  
* Singleton (單例模式) [done]
  > 確保一個類只有一個實例，並提供對該實例的全局訪問。
  > 系統中某項資源只能有一個，使用這個設計，可以確保物件個體只有一個。 

Structural pattern

> 可以合成 class 跟 object 到更大的結構中。

* Adapter (適配器模式) [done]
  > 通過轉換已經存在類別的接口以適應而不改變它。
  > Adapter分成兩種：繼承 (Class way)、組合 (Object way)
  
  > 插頭兩孔轉三孔
* Bridge (橋接模式) [done]    
    > 將抽象與實作解耦合，使他們都可以獨立地變化。
* Composite (組合模式)[done]
    > 數個物件之間，呈現一種樹狀結構。物件之間可以組合。
    > => 樹狀目錄選單
* Decorator (裝飾者模式) [done]
    > 早餐店 -> 吐司和配料
* Facade (外觀模式) [done]
    >  主要是將眾多Class重新包裝成一個更好用的Class => 控制多台電器的遙控器    
* Flyweight (享元模式) [done]
    > 可在儲存和取出共用的物件、狀態等資訊。目的在於減少頻繁建立物件所消耗的資源 => 撲克牌遊戲(只要建立四個花色物件)
* Proxy (代理模式) [done]
    > 為其他物件提供一種代理以控制對這個物件的存取。

Behavior pattern
> 重點在 class 與 object 間的互動，以及各自的責任。

* Chain of Responsibility (責任鏈模式) [done]
    > 有幾個物件都能處理某種請求，但處理的能範圍(權限)不同，當這個物件沒有處理的權限時，能夠將這個請求，傳遞給下一個物件繼續處理。
    > -> 請假天數核決天數權限不同
* Command (命令模式) [done]
    > 它嘗試以物件來代表實際行動。命令物件可以把行動(action) 及其參數封裝起來，於是這些行動可以被：
    > - 重複多次
    > - 取消（如果該物件有實作的話）
    > - 取消後又再重做
* Interpreter (解釋器模式) [done]
    > 用來解釋、直譯一種語言的方法
    > -> 數字轉國字
* Iterator (迭代器模式) [done]
    >  迭代器提供一種方法來逐一訪問對象的元素，而不暴露其結構。 
* Mediator (中介者模式) [done]
    > 當物件和物件之間或有錯綜複雜的交互作用，可將這些關係交由另一物件(中介者)來處理，
以減少這些物件間的耦合。
    > -> Chatroom
* Memento (備忘錄模式) [done]
    > 備忘錄模式就是對某個類的狀態進行儲存下來，等到需要恢復的時候，可以從備忘錄中進行恢復。生活中這樣的例子經常看到，如備忘電話通訊錄，備份操作作業系統，備份資料庫等。

    > 在不破壞封裝的前提下，捕獲一個物件的內部狀態，並在該物件之外儲存這個狀態，這樣以後就可以把該物件恢復到原先的狀態。 
* Observer (觀察者模式) [done] 
	> 報社 -> 訂報者
* State (狀態模式) [done]
    >  當一個物件的行為取決於它的狀態，而且必須在執行時刻根據狀態改變它的行為時，就可以考慮使用狀態模式
    >  取代多個 if elseif else 的應用 	
* Strategy (策略模式) [done] 
    > 購物車
* Template Method (模板方法) [done]
    > 定義了一個演算法的步驟，並允許次類別為一個或多個步驟提供其實踐方式。讓次類別在不改變演算法架構的情況下，重新定義演算法中的某些步驟。

    > Template Method Pattern是基於繼承的代碼複用的基本技術，Template Method Pattern的結構和用法也是物件導向設計的核心。
* Visitor (訪問者模式) [done]
    > 當一個「物件結構」中的「元素」幾乎不會異動，但這些「元素的行為」常會增減，則適合用訪問者模式。
分類表

>Class: Class與其Sub-Class之間的關係，為靜態作用
>
>Object: 在執行時其中，作用於物件的Instance之間

|   |   |Creational|Structural|Behavioral|
|---|---|---|---|---|
|   |Class|Factory Method|Adapter(class)|Interpreter|
|   |   |   |   |Template Method|
|   |Object|Abstract Factory|Adapter(object)|Chain of Responsibility|
|   |   |Builder|Bridge|Command|
|   |   |Prototype|Composite|Iterator|
|   |   |Singleton|Decorator|Mediator|
|   |   |   |Facade|Mememto|
|   |   |   |Flyweight|Observer
|   |   |   |Proxy|State
|   |   |   |   |Strategy
|   |   |   |   |Visitor

# Reference
- 很多C#範例參考 [連結](http://www.dofactory.com/net/design-patterns)
- MarkDown 語法參考 [連結](http://markdown.tw/)
- Design Pattern Overview [連結](http://www.cjwind.idv.tw/Design-Pattern-Overview/)
- Design Patterns(設計模式) 自我整理 [連結](http://jimmy0222.pixnet.net/blog/post/37095632-design-patterns%28%E8%A8%AD%E8%A8%88%E6%A8%A1%E5%BC%8F%29-%E8%87%AA%E6%88%91%E6%95%B4%E7%90%86)
- Design Pattern (G4) - 淺談 Design Pattern [連結](http://limitedcode.blogspot.tw/2014/09/design-pattern-design-pattern.html)


