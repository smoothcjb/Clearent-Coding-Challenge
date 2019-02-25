using System;
using Xunit;
using InterestCalculation;
using System.Collections.Generic;


namespace InterestCalculation.Tests
{
    
    public class InterestCalculationTest
    {
        CalculateInterest newInterest = new CalculateInterest();
        
        [Fact]
        public void InterestForOnePersonOneWalletThreeCards()
        {
            //Arrange
            Wallet wallet = new Wallet(TestData.cardList1);
            Person person1 = new Person("James", wallet);
            var jamesWallet = wallet._creditCards;
            //Act
            double total = 0;   
            foreach (var card in jamesWallet)
            {
                int balance = card.Balance;
                double rate = card.Rate;
                var result = newInterest.CreditCardInterest(balance, rate);
                total += result;
                if(card.Name == "Visa") { Assert.Equal(10, result); }
                else if(card.Name == "MC") { Assert.Equal(5, result); }
                else if (card.Name =="Discover") { Assert.Equal(1, result); }               
            }
            Assert.Equal(16, total);
        }
        [Fact]
        public void InterestForOnePersonTwoWallets()
        {
            //Arrange
            Wallet wallet1 = new Wallet(TestData.cardList2);
            Wallet wallet2 = new Wallet(TestData.cardList3);
            Person person2 = new Person("Jane", wallet1, wallet2);
            var janeWallet1 = person2._wallets[0]._creditCards;
            var janeWallet2 = person2._wallets[1]._creditCards;
            //Act   
            double sum1 = 0;
            double sum2 = 0;
            foreach (var card in janeWallet1)
            {
                int balance = card.Balance;
                double rate = card.Rate;
                var result = newInterest.CreditCardInterest(balance, rate);
                sum1 += result;
                if (card.Name == "Visa") { Assert.Equal(10, result); }
                else if (card.Name == "Discover") { Assert.Equal(1, result); }
            }
            Assert.Equal(11, sum1);
        
            //wallet2 contains one MC
            foreach (var card in janeWallet2)
            {
                int balance = card.Balance;
                double rate = card.Rate;
                var result = newInterest.CreditCardInterest(balance, rate);
                sum2 += result;
                Assert.Equal(5, result);
            }
            double total = sum1 + sum2;
            Assert.Equal(16, total);
        }
        [Fact]
        public void InterestTwoPeoplTwoWallets()
        {
            //Arrange
            Wallet wallet3 = new Wallet(TestData.cardList4);
            Wallet wallet4 = new Wallet(TestData.cardList4);
            Person person3 = new Person("Mary", wallet3);
            Person person4 = new Person("Michael", wallet4);
            var maryWallet = person3._wallets[0]._creditCards;
            var michaelWallet = person4._wallets[0]._creditCards;

            //Act
            double sum1 = 0;
            double sum2 = 0;
            foreach (var card in maryWallet)
            {
                int balance = card.Balance;
                double rate = card.Rate;
                var result = newInterest.CreditCardInterest(balance, rate);
                sum1 += result;
                if (card.Name == "Visa") { Assert.Equal(10, result); }
                else if (card.Name == "MC") { Assert.Equal(5, result); }             
            }
            Assert.Equal(15, sum1);

            foreach (var card in michaelWallet)
            {
                int balance = card.Balance;
                double rate = card.Rate;
                var result = newInterest.CreditCardInterest(balance, rate);
                sum2 += result;
                if (card.Name == "Visa") { Assert.Equal(10, result); }
                else if (card.Name == "MC") { Assert.Equal(5, result); }
            }
            Assert.Equal(15, sum2);
            
        }
    }
}