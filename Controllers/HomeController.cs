using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;
using WebApplication.Models.HomeViewModels;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Result(ResultViewModel input)
        {
            // フォームからの入力(URL)を取得
            var url = input.Url;

            // Emotion API の Subscription Key をセット
            // お持ちの Subscription Key を YOUR_SUBSCRIPTION_KEY 部分にコピーしてください
            var eApiKey = Environment.GetEnvironmentVariable("EMOTION_API_KEY");

            // Emotion API を Call する EmotionServiceClient を生成
            var eClient = new EmotionServiceClient(eApiKey);
            
            // Emotion API を呼び出して結果を取得
            var eResult = await eClient.RecognizeAsync(url);
            var result = new ResultViewModel();
            result.Url = url;
            var eScores = eResult?.FirstOrDefault()?.Scores;

            // 検出された表情スコアをセット
            result.Anger = eScores.Anger;
            result.Contempt = eScores.Contempt;
            result.Disgust = eScores.Disgust;
            result.Fear = eScores.Fear;
            result.Happiness = eScores.Happiness;
            result.Neutral = eScores.Neutral;
            result.Sadness = eScores.Sadness;
            result.Surprise = eScores.Surprise;

            return View(result);
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
