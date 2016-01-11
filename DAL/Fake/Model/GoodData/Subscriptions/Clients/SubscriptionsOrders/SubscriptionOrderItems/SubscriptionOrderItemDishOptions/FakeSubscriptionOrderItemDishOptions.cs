using System.Collections.Generic;
using DAL.Fake.Model.LookUp.DishOption;
using Model;

namespace DAL.Fake.Model.GoodData.Subscriptions.Clients.SubscriptionsOrders.SubscriptionOrderItems.SubscriptionOrderItemDishOptions
{
    public class FakeSubscriptionOrderItemDishOptions
    {
        public List<OrderSubscriptionItemDishOption> MySubscriptionOrderItemDishOptions;

        public FakeSubscriptionOrderItemDishOptions()
        {
            InitializeOrderItemList();
        }

        public void InitializeOrderItemList()
        {
            MySubscriptionOrderItemDishOptions = new List<OrderSubscriptionItemDishOption> {
                FirstSubscriptionOrderItemDishOption(), SecondSubscriptionOrderItemDishOption(),
                ThirdSubscriptionOrderItemDishOption(),
            };
        }



        public OrderSubscriptionItemDishOption FirstSubscriptionOrderItemDishOption()
        {
            return new OrderSubscriptionItemDishOption
          {
              //Required Side
              OrderSubscriptionItemDishOptionId = 1,
              DishOptionChoiceId = 3,
              DishOptionChoiceValue = "Cucumber Salad",
              DishOptionId = (int)DishOptionType.Values.FakeRequiredSideTwelveOptionChoices,
              Instructions = "no Mayone Please",
              OrderSubscriptionItemId = 1
          };


        }

        public OrderSubscriptionItemDishOption SecondSubscriptionOrderItemDishOption()
        {
            //Optional Side
            return new OrderSubscriptionItemDishOption
            {
                OrderSubscriptionItemDishOptionId = 2,
                DishOptionChoiceId = 17,
                DishOptionChoiceValue = "House Salad",
                DishOptionId = (int)DishOptionType.Values.FakeOptionalSideThreeOptionChoices,
                Instructions = "More Lettuce",
                OrderSubscriptionItemId = 1
            };
        }

        public OrderSubscriptionItemDishOption ThirdSubscriptionOrderItemDishOption()
        {

            return new OrderSubscriptionItemDishOption
             {
                 //Required Side
                 OrderSubscriptionItemDishOptionId = 3,
                 DishOptionChoiceId = 14,
                 DishOptionChoiceValue = "New York Strip Steak",
                 DishOptionId = (int)DishOptionType.Values.FakeRequiredSideThreeOptionChoices,
                 Instructions = "no Mayone Please",
                 OrderSubscriptionItemId = 2
             };
        }


    }
}
