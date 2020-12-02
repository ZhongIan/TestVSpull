
# 需注意

    * 資料庫資料太少
    * 刪除資料時，所有有關聯的資料會階層式刪除
      * 販售項目刪除需注意其他資料表有無關聯，會一併刪除
    * 所有功能都有加上權限，會要求相應身分(跳轉至燈入頁)

# 未合併

    註冊資料檢驗Email 
    上傳圖片的樣式(淺色圖不好看)

    未登入阻擋 前端 樣式

# 未實作完成

    首頁 搜尋結果: 我的最愛顯現，加入

    未登入阻擋 跳轉回前頁面(目前登入都匯到會員中心)

        我的最愛 加入
            首頁 搜尋結果

        訂購品項


    需要AJAX: 
        我的最愛 加入
        [私廚販售項目清單] 上架

# AccController

/Acc/

// === 登入 ===

/Acc/login

// === 登出 ===

/Acc/Logout

```
會員中心{ 
    [註冊 註冊成功] 
    [編輯基本資料 編輯私廚簡介] 
    [會員中心(一般) 會員中心(私廚)] 
    [我的最愛] 
}
                   
私廚創建 私廚編輯
```

// === [會員中心(一般) 會員中心(私廚)] ===

/Acc/center

// === 註冊 ===

/Acc/register

// === 註冊成功 ===

/Acc/registersuccess

// === [編輯基本資料] ===

/Acc/memberinfo

// === [私廚創建] ===

/Acc/chefCreate

// === 私廚編輯 ===

/Acc/chefEdit

// === [我的最愛] ===

/Acc/favorite 

```
還沒有加入方法
```

# ProdController

/Prod/

```
私廚 { 
    [私廚販售項目清單] 
    [(新增)(編輯)販售項目] 
    [(新增)(編輯)菜色] 
    [設定可預訂時間] 
}
```

// === [設定可預訂時間] === 

/Prod/calendar

// === [私廚販售項目清單] ===

/Prod/salesItemList

// === 項目創建 === 

/Prod/productCreate

// === 項目編輯 ===

/Prod/productEdit

// === 菜品創建 === 

/Prod/dishCreate

// === 菜品編輯 === 

/Prod/dishEdit

// === 菜品刪除 ===

/Prod/dishDelete

# OrderController

/Order/

```
交易紀錄{ 
    [儲值點數 儲值成功] 
    [交易紀錄] 
    [私廚資訊] 
    [客戶資訊] 
    [填寫評價] 
    [品項訂購]
    }
    私廚點選完成服務
```

// === [儲值點數] ===

/Order/buyPoint

// === [儲值成功] 重定向到 [交易紀錄] transaction ===

/Order/buyPointSuccess

// === [交易紀錄] ===

/Order/transaction

// === 私廚點選完成服務 ===

/Order/finish

// === [私廚資訊] ===

/Order/chefInfo

// === [客戶資訊] ===

/Order/clientInfo

// === [填寫評價] ===

/Order/evaluate

// === [品項訂購] ===

/Order/salesItem

# HomeController

// === 首頁 ===

/Home/Index

# SearchResultController

/SearchResult/

// === 搜索結果 ===

// === 5條件都要填資料 ===

/SearchResult/SearchByCondition

// === 關鍵字 ===

/SearchResult/SearchByKeyWord











