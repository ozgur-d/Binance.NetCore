﻿using Binance.NetCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Binance.NetCore.Data.Interface
{
    public interface IBinanceRepository
    {
        /// <summary>
        /// Check if the Exchange Repository is ready for trading
        /// </summary>
        /// <returns>Boolean of validation</returns>
        bool ValidateExchangeConfigured();

        /// <summary>
        /// Get exchange and symbol information
        /// </summary>
        /// <returns>ExchangeInfo object</returns>
        Task<ExchangeInfo> GetExchangeInfo();

        /// <summary>
        /// Get exchange trading pairs
        /// </summary>
        /// <returns>Collection of trading pairs</returns>
        Task<string[]> GetTradingPairs();

        /// <summary>
        /// Get exchange trading pairs by base pair
        /// </summary>
        /// <param name="baseSymbol">Base symbol of trading pair</param>
        /// <returns>Collection of trading pairs</returns>
        Task<string[]> GetTradingPairs(string baseSymbol);

        /// <summary>
        /// Get details of trading pair
        /// </summary>
        /// <param name="pair">Trading pair to find</param>
        /// <returns>Symbol object</returns>
        Task<Symbol> GetTradingPairDetail(string pair);

        /// <summary>
        /// Get details of all trading pairs
        /// </summary>
        /// <returns>Collection of Symbol objects</returns>
        Task<Symbol[]> GetTradingPairDetails();

        /// <summary>
        /// Get account balance
        /// </summary>
        /// <returns>Account object</returns>
        Task<Account> GetBalance();

        /// <summary>
        /// Get order information
        /// </summary>
        /// <param name="symbol">string of symbol</param>
        /// <param name="orderId">long of orderId</param>
        /// <returns>OrderResponse object</returns>
        Task<OrderResponse> GetOrder(string symbol, long orderId);

        /// <summary>
        /// Get most recent current user order information
        /// </summary>
        /// <param name="symbol">string of symbol</param>
        /// <returns>Array OrderResponse object</returns>
        Task<OrderResponse[]> GetOrders(string symbol);

        /// <summary>
        /// Get all current user order information
        /// </summary>
        /// <param name="symbol">string of symbol</param>
        /// <param name="limit">Int of orders count to return, default 500 / max 1000</param>
        /// <returns>Array OrderResponse object</returns>
        Task<OrderResponse[]> GetOrders(string symbol, int limit = 500);

        /// <summary>
        /// Get all current user order information
        /// </summary>
        /// <param name="symbol">string of symbol</param>
        /// <param name="fromDate">from date</param>
        /// <param name="toDate">to date</param>
        /// <returns>Array OrderResponse object</returns>
        Task<OrderResponse[]> GetOrders(string symbol, DateTime? fromDate, DateTime? toDate);

        /// <summary>
        /// Get all open orders
        /// </summary>
        /// <param name="symbol">string of symbol</param>
        /// <returns>Array OrderResponse object</returns>
        Task<OrderResponse[]> GetOpenOrders(string symbol);

        /// <summary>
        /// Get Order Book for a pair
        /// </summary>
        /// <param name="symbol">string of trading pair</param>
        /// <param name="limit">Number of orders to return</param>
        /// <returns>OrderBook object</returns>
        Task<OrderBook> GetOrderBook(string symbol, int limit = 100);

        /// <summary>
        /// Post/Place a trade
        /// </summary>
        /// <param name="tradeParams">Trade to place</param>
        /// <returns>TradeResponse object</returns>
        Task<TradeResponse> PostTrade(TradeParams tradeParams);

        /// <summary>
        /// Delete/Cancel a trade
        /// </summary>
        /// <param name="tradeParams">Trade to delete</param>
        /// <returns>TradeResponse object</returns>
        Task<TradeResponse> DeleteTrade(CancelTradeParams tradeParams);

        /// <summary>
        /// Get Ticker for all pairs
        /// </summary>
        /// <returns>Collection of BinanceTick objects</returns>
        Task<IEnumerable<Tick>> GetCrytpos();

        /// <summary>
        /// Get Candlesticks for a trading pair
        /// </summary>
        /// <param name="pair">Trading symbol</param>
        /// <param name="interval">Time interval</param>
        /// <returns>Array of Candlestick objects</returns>
        Task<Candlestick[]> GetCandlestick(string pair, Interval interval);

        /// <summary>
        /// Get Candlesticks for a symbol
        /// </summary>
        /// <param name="symbol">Trading symbol</param>
        /// <param name="interval">Time interval</param>
        /// <param name="limit">Time limit</param>
        /// <returns>Array of Candlestick objects</returns>
        Task<Candlestick[]> GetCandlestick(string symbol, Interval interval, int limit);

        /// <summary>
        /// Get Candlesticks for a trading pair
        /// </summary>
        /// <param name="pair">Trading symbol</param>
        /// <param name="endTime">Last stick</param>
        /// <param name="interval">Time interval</param>
        /// <param name="limit">Time limit</param>
        /// <returns>Array of Candlestick objects</returns>
        Task<Candlestick[]> GetCandlestick(string pair, long endTime, Interval interval, int limit);

        /// <summary>
        /// Get Candlesticks for a trading pair
        /// </summary>
        /// <param name="pair">Trading symbol</param>
        /// <param name="endDate">Last stick</param>
        /// <param name="interval">Time interval</param>
        /// <param name="limit">Time limit</param>
        /// <returns>Array of Candlestick objects</returns>
        Task<Candlestick[]> GetCandlestick(string pair, DateTime endDate, Interval interval, int limit);

        /// <summary>
        /// Get Candlesticks for a trading pair
        /// </summary>
        /// <param name="pair">Trading symbol</param>
        /// <param name="startDate">1st stick</param>
        /// <param name="endDate">Last stick</param>
        /// <param name="interval">Time interval</param>
        /// <returns>Array of Candlestick objects</returns>
        Task<Candlestick[]> GetCandlestick(string pair, DateTime startDate, DateTime endDate, Interval interval);

        /// <summary>
        /// Get Candlesticks for a trading pair
        /// </summary>
        /// <param name="pair">Trading symbol</param>
        /// <param name="interval">Time interval</param>
        /// <param name="startTime">Time of 1st candlestick</param>
        /// <param name="endTime">Time of last candlestick</param>
        /// <param name="limit">Time limit</param>
        /// <returns>Array of Candlestick objects</returns>
        Task<Candlestick[]> GetCandlestick(string pair, Interval interval, long startTime, long endTime);

        /// <summary>
        /// Get 24hour ticker statistics
        /// </summary>
        /// <param name="symbol">Trading symbol (default = "")</param>
        /// <returns>Array of Tick objects</returns>
        Task<Tick[]> Get24HourStats(string symbol = "");

        /// <summary>
        /// Get latest price for all trading pairs
        /// </summary>
        /// <returns>Array of Tickers</returns>
        Task<Ticker[]> GetTickers();

        /// <summary>
        /// Get latest price for a trading pair
        /// </summary>
        /// <param name="pair">Trading pair</param>
        /// <returns>A Ticker object</returns>
        Task<Ticker> GetTicker(string pair);

        /// <summary>
        /// Get BinanceTime
        /// </summary>
        /// <returns>long of timestamp</returns>
        Task<ServerTime> GetBinanceTime();

        /// <summary>
        /// Withdraw funds from exchange
        /// </summary>
        /// <param name="symbol">Symbol of asset</param>
        /// <param name="address">Address to send funds to</param>
        /// <param name="amount">Decimal of amount</param>
        /// <returns>Withdrawal response</returns>
        Task<WithdrawalResponse> WithdrawFunds(string symbol, string address, decimal amount);

        /// <summary>
        /// Withdraw funds from exchange
        /// </summary>
        /// <param name="symbol">Symbol of asset</param>
        /// <param name="address">Address to send funds to</param>
        /// <param name="amount">Decimal of amount</param>
        /// <param name="description">Description of address</param>
        /// <returns>Withdrawal response</returns>
        Task<WithdrawalResponse> WithdrawFunds(string symbol, string address, decimal amount, string description);

        /// <summary>
        /// Withdraw funds from exchange
        /// </summary>
        /// <param name="symbol">Symbol of asset</param>
        /// <param name="address">Address to send funds to</param>
        /// <param name="addressTag">Secondary address identifier</param>
        /// <param name="amount">Decimal of amount</param>
        /// <returns>Withdrawal response</returns>
        Task<WithdrawalResponse> WithdrawFunds(string symbol, string address, string addressTag, decimal amount);

        /// <summary>
        /// Withdraw funds from exchange
        /// </summary>
        /// <param name="symbol">Symbol of asset</param>
        /// <param name="address">Address to send funds to</param>
        /// <param name="addressTag">Secondary address identifier</param>
        /// <param name="amount">Decimal of amount</param>
        /// <param name="description">Description of address</param>
        /// <returns>Withdrawal response</returns>
        Task<WithdrawalResponse> WithdrawFunds(string symbol, string address, string addressTag, decimal amount, string description);

        /// <summary>
        /// Get all deposit history
        /// </summary>
        /// <param name="status">deposit status (default all)</param>
        /// <returns>Array of deposits</returns>
        Task<Deposit[]> GetDepositHistory(DepositStatus status = DepositStatus.all);

        /// <summary>
        /// Get deposit history for an asset
        /// </summary>
        /// <param name="asset">string of asset</param>
        /// <param name="status">deposit status (default all)</param>
        /// <returns>Array of deposits</returns>
        Task<Deposit[]> GetDepositHistory(string asset, DepositStatus status = DepositStatus.all);

        /// <summary>
        /// Get deposit history for an asset
        /// </summary>
        /// <param name="asset">string of asset</param>
        /// <param name="status">deposit status (default all)</param>
        /// <param name="startTime">Start of date range</param>
        /// <param name="endTime">End of date range</param>
        /// <returns>Array of deposits</returns>
        Task<Deposit[]> GetDepositHistory(string asset, DepositStatus status, DateTime startTime, DateTime endTime);

        /// <summary>
        /// Get all withdrawal history
        /// </summary>
        /// <param name="status">withdrawal status (default all)</param>
        /// <returns>Array of withdrawal</returns>
        Task<Withdrawal[]> GetWithdrawalHistory(WithdrawalStatus status = WithdrawalStatus.all);

        /// <summary>
        /// Get withdrawal history for an asset
        /// </summary>
        /// <param name="asset">string of asset</param>
        /// <param name="status">withdrawal status (default all)</param>
        /// <returns>Array of withdrawal</returns>
        Task<Withdrawal[]> GetWithdrawalHistory(string asset, WithdrawalStatus status = WithdrawalStatus.all);

        /// <summary>
        /// Get withdrawal history for an asset
        /// </summary>
        /// <param name="asset">string of asset</param>
        /// <param name="status">withdrawal status (default all)</param>
        /// <param name="startTime">Start of date range</param>
        /// <param name="endTime">End of date range</param>
        /// <returns>Array of withdrawal</returns>
        Task<Withdrawal[]> GetWithdrawalHistory(string asset, WithdrawalStatus status, DateTime startTime, DateTime endTime);
        
        /// <summary>
        /// Get deposit address for an asset
        /// </summary>
        /// <param name="asset">string of asset</param>
        /// <param name="status">Account status</param>
        /// <param name="recvWindow">Recieving window?</param>
        /// <returns>String of address</returns>
        Task<Dictionary<string, string>> GetDepositAddress(string asset, bool? status = null, long recvWindow = 0);
    }
}
