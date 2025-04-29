# Software Rendering Plugin for SimHub

## これは何？
SimHub のダッシュボードを利用している際に、GPU 使用率が高いことが原因でダッシュボードの更新が止まってしまうことがあります。

このプラグインはその現象を回避するため、SimHub 全体をソフトウェア レンダリング、つまり GPU を利用しないモードに切り替えます。

## 使い方
+ Relase ページから DLL を取得
+ SimHub に DLL をインストール
+ 「Software Rendering」のトグルを ON にする

## 注意事項
+ ダッシュボードのレンダリング が「WPF rendering engine」になっている必要があります。
  + HTML rendering engine (WebView2) では効果がありません。
  + Remote Rendering は使っていないので解りません。
+ On にすると CPU の使用率が上がります。
