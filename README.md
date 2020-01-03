# AtCoderBeginnersSelection

AtCoder 過去問精選10問をC#で解く。

## Working memo

- ABC081B
  - LINQ で配列操作をして25ms。C# での最速回答が20ms?
    - for loop で素朴に実装した方が速そう。
  - Array<string> -> Array<int>の変換もLINQ.Selectで行なったが、for loopの方がいいかも

- ABC087B
  - for loop で素朴に実装。20ms。
  - Console.ReadLine() を wrap して Reader class をつくったほうがよさそう？ parse intとかSplitとか毎回書くのは時間がかかる。

- ABC083B
  - 10進整数の各桁の和の求め方。

- ABC088B
  - LINQ で配列操作をして31ms。
    - sortはArray.sortを使うのが良さそう。
  - string[] -> int[]への変換も、Array.ConvertAllをつかえそう。
  - List<int>にしてList.Sort()でもよかったかも。そんなに遅くないっぽい
