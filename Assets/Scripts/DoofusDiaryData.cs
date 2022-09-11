using Newtonsoft.Json;

public class PlayerData
{
    public int speed;
}

public class PulpitData
{
    [JsonProperty(PropertyName = "min_pulpit_destroy_time")]
    public int minPulpitDestroyTime;
    [JsonProperty(PropertyName = "max_pulpit_destroy_time")]
    public int maxPulpitDestroyTime;

    [JsonProperty(PropertyName = "pulpit_spawn_time")]
    public double pulpitSpawnTime;
}

public class DoofusDiaryData
{
    [JsonProperty(PropertyName = "player_data")]
    public PlayerData playerData;

    [JsonProperty(PropertyName = "pulpit_data")]
    public PulpitData pulpitData;
}
