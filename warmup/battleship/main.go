package main

func getHitProbability(R int32, C int32, G [][]int32) float64 {
	b := 0.0
	var r int32
	var c int32
	for r = 0; r < R; r++ {
		for c = 0; c < C; c++ {
			if G[r][c] == 1 {
				b++
			}
		}
	}
	return b / float64(R*C)
}
