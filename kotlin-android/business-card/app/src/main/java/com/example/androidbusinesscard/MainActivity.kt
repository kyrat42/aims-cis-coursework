package com.example.androidbusinesscard

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.BorderStroke
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.border
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.shape.CircleShape
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.draw.alpha
import androidx.compose.ui.draw.clip
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.res.stringResource
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.androidbusinesscard.ui.theme.AndroidBusinessCardTheme
import org.intellij.lang.annotations.JdkConstants.HorizontalAlignment

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            AndroidBusinessCardTheme {
                // A surface container using the 'background' color from the theme
                Surface(
                    modifier = Modifier.fillMaxSize(),
                    color = Color.White
                ) {
                    Container()
                }
            }
        }
    }
}

@Composable
fun Container(modifier: Modifier = Modifier) {
    Column (
        modifier = modifier
            .padding(8.dp),
        horizontalAlignment = Alignment.CenterHorizontally,
        verticalArrangement = Arrangement.spacedBy(16.dp)   // found on Google for gap spacing
    ) {
        HeadShotImage()
        Header()
        LinkedIn()
        Email()
    }
}

@Composable
fun HeadShotImage(modifier: Modifier = Modifier) {
    val image = painterResource(id = R.drawable.me)
    Box {
        Image(
            painter = image,
            contentDescription = "Headshot image of Kyra Thomas",
            contentScale = ContentScale.Crop,

            // I found this code on Google to circle-crop :)
            modifier = Modifier
                .clip(CircleShape)
                .border(
                    BorderStroke(5.dp, Color(0xFF8C52FF)),
                    CircleShape
                )
                .background(color = Color(0xFFD2BBFF))
        )
    }
}

@Composable
fun LinkedInIcon(modifier: Modifier = Modifier) {
    val image = painterResource(id = R.drawable.linkedin)
    Box {
        Image(
            painter = image,
            contentDescription = "LinkedIn logo in a blue and purple gradient",
            contentScale = ContentScale.Crop,
            modifier = Modifier
        )
    }
}

@Composable
fun EmailIcon(modifier: Modifier = Modifier) {
    val image = painterResource(id = R.drawable.email)
    Box {
        Image(
            painter = image,
            contentDescription = "LinkedIn logo in a blue and purple gradient",
            contentScale = ContentScale.Crop,
            modifier = Modifier
        )
    }
}

@Composable
fun Header(modifier: Modifier = Modifier) {
        Text(
            stringResource(R.string.name),
            fontSize = 30.sp,
            textAlign = TextAlign.Center,
            color = Color(0xFF8C52FF)
        )

        Text(
            stringResource(R.string.title),
            fontSize = 15.sp,
            textAlign = TextAlign.Center
        )

        Text(
            stringResource(R.string.address),
            fontSize = 15.sp,
            textAlign = TextAlign.Center
        )
}

@Composable
fun LinkedIn(modifier: Modifier = Modifier) {
    Row (
        modifier = modifier,
        verticalAlignment = Alignment.CenterVertically,
        horizontalArrangement = Arrangement.spacedBy(16.dp)
    ) {
        LinkedInIcon()
        Text(
            stringResource(R.string.linkedInLink),
            fontSize = 10.sp,
            textAlign = TextAlign.Center,
        )
    }
}

@Composable
fun Email(modifier: Modifier = Modifier) {
    Row (
        modifier = modifier,
        verticalAlignment = Alignment.CenterVertically,
        horizontalArrangement = Arrangement.spacedBy(16.dp)
    ) {
        EmailIcon()
        Text(
            stringResource(R.string.emailAddress),
            fontSize = 10.sp,
            textAlign = TextAlign.Center
        )
    }
}

@Preview(showBackground = true)
@Composable
fun ContainerPreview() {
    AndroidBusinessCardTheme {
        Container()
    }
}