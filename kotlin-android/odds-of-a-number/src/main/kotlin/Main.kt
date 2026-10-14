import kotlin.random.Random

fun main(args: Array<String>) {
    val number = Random.nextInt(2, 13)   // gets a random int between 2 and 12

    var total = 0.0
    var hitNumber = 0.0

    // loop through possibilities
    for (i in 1..6) {
        for (j in 1..6) {
            if (i + j == number) hitNumber++
            total++
        }
    }

    // calculate odds
    val odds = hitNumber / total

    // output
    println("The odds of rolling a $number with two D6 dice is ${odds * 100}%.")
}