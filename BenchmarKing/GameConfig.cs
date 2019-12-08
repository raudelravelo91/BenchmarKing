using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarKing
{
    public enum D3API
    {
        Vulkan,
        DX12,
        DX11,
        DX9
    }

    public class GameConfig
    {
        public Game Game { get; protected set; }
        public string Name { get; protected set; }
        public D3API D3API { get; protected set; }

        protected Dictionary<string, string> _configValues;
        public GameConfig(string name, Game game, D3API d3api)
        {
            Name = name;
            Game = game;
            _configValues = new Dictionary<string, string>();
            D3API = d3api;
        }

        public bool TryAddConfig(string name, string value)
        {
            return _configValues.TryAdd(name, value);
        }

        public void UpdateConfig(string name, string newValue)
        {
            if (!_configValues.ContainsKey(name))
                throw new Exception($"Config {name} does not exist.");

            _configValues[name] = newValue;
        }

        public string GetConfigValue(string name)
        {
            return _configValues[name];
        }

        public bool ContainsConfig(string name)
        {
            return _configValues.ContainsKey(name);
        }

        public IEnumerable<string> GetConfigNames()
        {
            return _configValues.Keys;
        }
    }
}
