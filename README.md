# JsonDataSetTest

有個DataSet物件透過Newtonsoft.Json做了JSON序列化，裡頭有個$Type特別標註了byte[]型別的資料欄位，但反序列化會失敗。

* Json 針對DataSet、DataTable這樣的物件做序列化時，在型別上會有前後不一致的問題，
  例如int型別的column會變long，byte[] 會變成string
  後來查到 用JsonSerializerSettings宣告來產出$Type標示型別，感覺快成功了，就差反序列話還是會失敗囉
