<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format" xmlns:yweather="http://xml.weather.yahoo.com/ns/rss/1.0">
	<xsl:template match="/">
		<html>
			<head>
				<meta charset="utf-8" http-equiv="X-UA-Compatible" content="IE=edge"/>
				<title>Weather Forecast</title>
				<style type="text/css">
        body{
            color:white;
        }

        #container {
            background-image: url(https://s.yimg.com/os/mit/media/m/weather/images/fallbacks/lead/clear_d-e618500.jpg);
            text-shadow: 2px 2px 1px black;

            padding: 5px;
            font-family: Arial;
        }

        #general {
            padding: 10px;
        }

        #location {
            font-size: 40px;
        }

        #region {
            height: 100px;
        }

        #weather {
            margin: auto auto 15px auto;
            font-size: 30px;
        }

        #temperature {
            font-size: 80px;
        }

        .subContainer {

            background-color: rgba(0, 0, 0, 0.6);
            padding: 10px;
            margin: 10px;

        }

        .subContainer th {
            font-size: 24px;
            text-align: left;
            margin-bottom: 10px;

        }

        .forecastTable {
            width: 100%;
        }

        .forecastTable td {
            border: 0px solid #ffffff;
            border-bottom-width: 1px;
            height: 30px;
        }

        .blueText {
            color:lightskyblue;
            margin: 0 30px 0 10px;
        }

        .forecastDay{
			width:200px;
            display:inline-block;
        }

        .forecastWeather {
            display:inline-block;
            margin: 0px auto;
            text-align: center;
            width:400px;
        }

        .forecastHigh {
            display:inline-block;
            float: right;
            padding-right: 10px;
            width:30px;
        }

        .forecastLow {
            display:inline-block;
            float: right;
            width:30px;
        }


    </style>
			</head>
			<body>
				<div id="container">
					<div id="general">
						<div id="location">
							<xsl:value-of select="/rss/channel/yweather:location/@city"/>
						</div>
						<div id="region">
							<xsl:value-of select="/rss/channel/yweather:location/@region"/>
						</div>
						<div id="weather">
							<xsl:value-of select="/rss/channel/item/yweather:condition/@text"/>
						</div>
						<div>
							<span>Highest<span class="blueText"><xsl:value-of select="/rss/channel/item/yweather:forecast[1]/@high"/>°</span>
							</span>
							<span id="high">Lowest<span class="blueText"><xsl:value-of select="/rss/channel/item/yweather:forecast[1]/@low"/>°</span>
							</span>
						</div>
						<div id="temperature">
							<xsl:value-of select="/rss/channel/item/yweather:condition/@temp"/>°
						</div>
					</div>
					<div class="subContainer">
						<table class="forecastTable">
							<tr>
								<th>Forecast</th>
							</tr>
							<xsl:for-each select="/rss/channel/item/yweather:forecast">
								<tr>
									<td>
										<span class="forecastDay">
											<xsl:choose>
												<xsl:when test="position()=1">Today</xsl:when>
												<xsl:otherwise><xsl:value-of select="@day"/></xsl:otherwise>
											</xsl:choose> (<xsl:value-of select="@date"/>)
										</span>
										<span class="forecastWeather">
											<xsl:value-of select="@text"/>
										</span>
										<span class="forecastLow">
											<span class="blueText">
												<xsl:value-of select="@low"/>°</span>
										</span>
										<span class="forecastHigh">
											<xsl:value-of select="@high"/>°</span>
									</td>
								</tr>
							</xsl:for-each>
						</table>
					</div>
					<div class="subContainer">
						<table>
							<tr>
								<th>Details</th>
							</tr>
							<tr>
								<td>Feels like<span class="blueText"><xsl:value-of select="/rss/channel/yweather:wind/@chill"/>°</span>Visibility<span class="blueText"><xsl:value-of select="/rss/channel/yweather:atmosphere/@visibility"/>ml</span>Humidity
                    <span class="blueText"><xsl:value-of select="/rss/channel/yweather:atmosphere/@humidity"/>%</span>
                    <div>Updated: <span class="blueText"><xsl:value-of select="/rss/channel/lastBuildDate"/></span></div>
								</td>
							</tr>
						</table>
					</div>
				</div>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
