﻿# AtCoderBeginnersSelection

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

- ABC085C
  - 愚直に3重for loopで実装したらNが大きくなった時めちゃくちゃ遅い・・・。
    - 計算量がO(n^3)になっている…。
  - 変数のうち、3つ目は自明であるため3重forにする必要がなかった。
    - 計算量は0(n^3) -> O(n^2)に。

- ABC049C
  - ACするけど1秒近くかかる。。。
    - 別の解法を考えよう。

- ABC086C
  - 自力で解けていない。。
    - パリティに関する例題を解く
	- ほかの人の解法を見る。