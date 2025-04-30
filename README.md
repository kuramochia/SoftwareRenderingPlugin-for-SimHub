# Software Rendering Plugin for SimHub

## これは何？
SimHub のダッシュボードを利用している際に、GPU 使用率が高いことが原因でダッシュボードの更新が止まってしまうことがあります。

このプラグインはその現象を回避するため、SimHub プロセス全体をソフトウェア レンダリング、つまり GPU を利用せず、CPU のみで描画するモードに切り替えます。

## 使い方
+ Relase ページから DLL を取得
+ SimHub に DLL をインストール
+ 「Software Rendering」のトグルを ON にする

## 注意事項
+ ダッシュボードのレンダリング が「WPF render engine」に設定されている必要があります。
  + HTML render engine (WebView2) では効果がありません。
  + Remote render は使っていないので解りません。
+ 有効にすると CPU の使用率が上がります。
