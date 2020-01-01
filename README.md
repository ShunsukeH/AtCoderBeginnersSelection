# AtCoderBeginnersSelection

AtCoder 過去問精選10問をC#で解く。

## Working memo

- ABC081B
  - LINQ で配列操作をして25ms。C# での最速回答が20ms?
    - for loop で素朴に実装した方が速そう。
  - Array<string> -> Array<int>の変換もLINQ.Selectで行なったが、for loopの方がいいかも