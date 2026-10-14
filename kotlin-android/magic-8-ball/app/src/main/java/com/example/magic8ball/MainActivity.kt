package com.example.magic8ball

import android.media.Image
import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.Image
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.wrapContentHeight
import androidx.compose.foundation.layout.wrapContentSize
import androidx.compose.material3.Button
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.res.stringResource
import androidx.compose.ui.semantics.Role.Companion.Image
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.magic8ball.ui.theme.Magic8BallTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            Magic8BallApp();
        }
    }
}

// preview
@Preview
@Composable
fun Magic8BallApp() {
    Magic8Ball();
}

// UI composable
@Composable
fun Magic8Ball(modifier: Modifier = Modifier
    .fillMaxSize()
    .wrapContentSize(Alignment.Center)
) {
    val resultsArray = arrayOf<String>("", stringResource(id = R.string.certain), stringResource(R.string.concentrate), stringResource(R.string.doubtful), stringResource(R.string.rely), stringResource(R.string.likely), stringResource(R.string.yes))
    var result by remember { mutableStateOf(0)}
    Column(
        modifier = modifier,
        horizontalAlignment = Alignment.CenterHorizontally
    ) {
        Box(
            contentAlignment = Alignment.Center
        ) {
            Image(
                painter = painterResource(R.drawable.magic_8_ball),
                contentDescription = stringResource(R.string.ball)
            )

            Text(
                resultsArray[result],
                color = Color.White,
                fontSize = 10.sp
            )
        }
        Spacer(modifier = Modifier.height(16.dp))
        Button({result = (1..6).random()}) {
            Text(stringResource(R.string.ask))
        }
    }
}