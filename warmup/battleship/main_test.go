package main

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestGetHitProbability(t *testing.T) {
	assert.InDelta(t, 0.5, getHitProbability(2, 3, [][]int32{
		{0, 0, 1},
		{1, 0, 1},
	}), 0.001)
	assert.InDelta(t, 1.0, getHitProbability(2, 2, [][]int32{
		{1, 1},
		{1, 1},
	}), 0.001)
}
