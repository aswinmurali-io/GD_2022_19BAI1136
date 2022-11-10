using Newtonsoft.Json;

public class PlayerData
{
    public int speed;
}

public class PulpitData
{
    [JsonProperty(PropertyName = "min_pulpit_destroy_time")]
    public int minDestroyTime;
    [JsonProperty(PropertyName = "max_pulpit_destroy_time")]
    public int maxDestroyTime;

    [JsonProperty(PropertyName = "pulpit_spawn_time")]
    public double spawnTime;
}

public class DoofusDiaryData
{
    [JsonProperty(PropertyName = "player_data")]
    public PlayerData playerData;

    [JsonProperty(PropertyName = "pulpit_data")]
    public PulpitData pulpitData;
}
