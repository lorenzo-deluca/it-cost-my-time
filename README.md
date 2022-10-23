# How much time does an item cost you?
This simple personal finance web-app allows you to calculate **how much time it costs you to purchase an item**.

You can find the application already working at
<a href="https://lorenzo-deluca.github.io/it-cost-my-time/"  onclick="return ! window.open(this.href);" rel="noreferrer noopener" target="_blank">https://lorenzo-deluca.github.io/it-cost-my-time/</a>

If you like this project you can support me with :coffee: or simply put a :star: to this repository :blush:

<a href="https://www.buymeacoffee.com/lorenzodeluca" target="_blank">
  <img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" width="150px">
</a>

> **disclaimer** the application runs entirely client-side Web Assembly, the data you enter will be saved within your browser's Local Storage, no data is sent to remote servers!

![App Screenshot](/images/app-screen.png)

## Income
You will need to enter parameters to account your **income** (after tax): 
- **monthly** in these case you will be able to enter the **number of months** pay (by default 13)
 - **annual pay**
 - The number of **days worked in a week** 
 - The number of **hours worked for each day**.

## Saving Rate

Here you need to state how much of your income you can save as a percentage (income - fixed expenses)

## Item Cost

Finally here you have to say how much the item you would like to buy costs, the application will calculate how many hours or days of work (of savings) it will cost you.
By changing all the other values you will be able to see how much the time cost of the object varies as the parameters change.

Once you have saved your data you can call up the application by entering the price of an item by entering it in the "amount" parameter (?amount=<price>) 
<a href="https://lorenzo-deluca.github.io/it-cost-my-time?amount=1500" >(like this)</a>

## License
GNU AGPLv3 © [Lorenzo De Luca][https://lorenzodeluca.dev]
