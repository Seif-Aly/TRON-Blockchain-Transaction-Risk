# TRON Blockchain Transaction Risk
Этот проект получает уровень риска для транзакций на блокчейне TRON с использованием общедоступного API, предоставляемого TronScan.
## Полный Response
``` {"contract_map":{"TVBkD4V2qmLGAoQjBgMEDoPihaYgEtiLau":false,"TQ793kg2ckYZtbRcUQLfTLwtccCQgGuMyk":false},"contractRet":"SUCCESS","data":"","contractInfo":{},"contractType":2,"toAddress":"TVBkD4V2qmLGAoQjBgMEDoPihaYgEtiLau","confirmed":true,"block":63895653,"riskTransaction":true,"timestamp":1722332607000,"info":{},"normalAddressInfo":{"TVBkD4V2qmLGAoQjBgMEDoPihaYgEtiLau":{"risk":false},"TQ793kg2ckYZtbRcUQLfTLwtccCQgGuMyk":{"risk":false}},"cost":{"net_fee_cost":1000,"date_created":1722332607,"fee":0,"energy_fee_cost":420,"net_usage":282,"multi_sign_fee":0,"net_fee":0,"energy_penalty_total":0,"energy_usage":0,"energy_fee":0,"energy_usage_total":0,"memoFee":0,"origin_energy_usage":0,"account_create_fee":0},"noteLevel":3,"addressTag":{},"revert":false,"confirmations":65816,"trigger_info":{},"signature_addresses":[],"ownerAddress":"TQ793kg2ckYZtbRcUQLfTLwtccCQgGuMyk","srConfirmList":[{"address":"TVFKwzE8qeETLaZEHMx2tjEsdnujAgAWaA","name":"BlockchainOrg","block":63895653,"url":"http://blockchain.org"},{"address":"TN2W4cc7a4dsYyTLiLMWa9m7jVpdLjGvYs","name":"Huobi_Wallet","block":63895654,"url":"https://www.huobiwallet.com/"},{"address":"TJBtdYunmQkeK5KninwgcjuK1RPDhyUWBZ","name":"JD Investment","block":63895655,"url":"JDinvestment"},{"address":"TTW663tQYJTTCtHh6DWKAfexRhPMf2DxQ1","name":"TRONALLIANCE","block":63895656,"url":"http://tronalliance.org"},{"address":"TKSXDA8HfE9E1y39RczVQ1ZascUEtaSToF","name":"CryptoChain","block":63895657,"url":"http://cryptochain.network"},{"address":"TUD4YXYdj2t1gP5th3A7t97mx1AUmrrQRt","name":"TRONGrid","block":63895658,"url":"https://www.trongrid.io"},{"address":"TTMNxTmRpBZnjtUnohX84j25NLkTqDga7j","name":"TronSpark","block":63895659,"url":"https://tronspark.com"},{"address":"TBsyKdNsCKNXLgvneeUJ3rbXgWSgk6paTM","name":"StakedTron","block":63895660,"url":"https://staked.us"},{"address":"TQhuVjZtmp6k4fPmGZLr4wyXdziCVSPkEX","name":"Google Cloud","block":63895661,"url":"https://cloud.google.com/"},{"address":"TNeEwWHXLLUgEtfzTnYN8wtVenGxuMzZCE","name":"OKCoinJapan","block":63895662,"url":"https://okcoin.jp/"},{"address":"TCEo1hMAdaJrQmvnGTCcGT2LqrGU4N7Jqf","name":"TRONScan","block":63895663,"url":"https://tronscan.org"},{"address":"TTxrh32VJveqiYRwbLEX2wLTMFCfbpAUQj","name":"OKX Earn","block":63895664,"url":"https://www.okx.com/earn/home"},{"address":"TTcYhypP8m4phDhN6oRexz2174zAerjEWP","name":"CryptoGuyInZA","block":63895665,"url":"https://www.cryptoguyinza.co.za/"},{"address":"TLyqzVGLV1srkB7dToTAEqgDSfPtXRJZYH","name":"Binance Staking","block":63895666,"url":"https://www.binance.com/en/staking"},{"address":"TJvaAeFb8Lykt9RQcVyyTFN2iDvGMuyD4M","name":"Poloniex","block":63895667,"url":"https://poloniex.com/"},{"address":"TAAdjpNYfeJ2edcETNpad1QpQWJfyBdB9V","name":"Ant Investment Group","block":63895668,"url":"antinvestmentgroup"},{"address":"TDpt9adA6QidL1B1sy3D8NC717C6L5JxFo","name":"Chain Cloud","block":63895669,"url":"chaincloud"},{"address":"TGyrSc9ZmTdbYziuk1SKEmdtCdETafewJ9","name":"Luganodes","block":63895670,"url":"https://luganodes.com"},{"address":"TQopP5GM68QoqLzpz8YReDfSoCMkvwcZYd","name":"cryptoAI","block":63895671,"url":"https://cryptoai.com"}],"hash":"853793d552635f533aa982b92b35b00e63a1c1add062c099da2450a15119bcb2","contractData":{"amount":10000000,"asset_name":"1005002","owner_address":"TQ793kg2ckYZtbRcUQLfTLwtccCQgGuMyk","to_address":"TVBkD4V2qmLGAoQjBgMEDoPihaYgEtiLau","tokenInfo":{"tokenLevel":"4","tokenId":"1005002","tokenName":"tron.ink","tokenDecimal":1,"tokenAbbr":"tron.ink","tokenCanShow":3,"tokenType":"trc10","vip":false,"tokenLogo":"https://static.tronscan.org/production/upload/logo/default.png"}},"internal_transactions":{}} ```

## Используемые пакеты
- System.Net.Http: For HTTP requests.
- System.Text.Json: For parsing JSON.

## Запустите код
git clone https://github.com/Seif-Aly/TRON-Blockchain-Transaction-Risk

cd TRON-Blockchain-Transaction-Risk

Откройте проект в предпочитаемой вами среде разработки на C#.

## Шаги по решению
1- Настройка проекта:

  -Создано новое консольное приложение на C#.
  
2-Установка необходимых пакетов:

  -Обеспечена доступность для использования System.Net.Http и System.Text.Json.
  
3-Внедрение решения:

  -Написан метод для получения данных о транзакциях из Transcan API.
  
  -Проанализировал ответ в формате JSON с помощью точки останова, чтобы найти и извлечь поле риска в информации о обычном адресе.
  
  -Просмотрел каждый адрес в информации о обычном адресе, чтобы определить его статус риска.
  
  -Добавлена обработка ошибок для устранения потенциальных проблем с HTTP-запросами.
  
