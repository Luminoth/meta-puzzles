package main

import (
	"strings"
)

func getWrongAnswers(N int32, C string) string {
	var s strings.Builder
	var i int32
	for i = 0; i < N; i++ {
		if C[i] == 'A' {
			s.WriteString("B")
		} else {
			s.WriteString("A")
		}
	}
	return s.String()
}
